$(".button-collapse").sideNav();

      items = [];
      var steamid = $("#steamid").html();

      function tick() {
      	$('.item-card').css("height",$('.item-card').width()+"px");
      	$('.item-card').css("font-size",$('.item-card').width()*.13+"px");

    		requestAnimationFrame(tick);
    	}
    	tick();

    	var prices = {};
      var apricething = {};

      var bot_sids = ['76561198191527437'];
      var cur_bot = 0;

    	function loadItems() {
    		$("#refresh-button").remove();
    		$("#loading").addClass("active");
    		$.getJSON("http://csgosnaffy.com/getPlayerInventory.php?steamid="+bot_sids[cur_bot], function(data) {
    			if(data.success) {
    				var i = 0;
    				var ready = true;
    				var invIndexes = [];
		    		for(var index in data.rgInventory) {
		    			invIndexes[i] = index;
		    			i++;
		    		}
		    		i = 0;
		    		$.getJSON("http://csgosnaffy.com/getPriceList.php?", function(pricelist) {
              apricething = pricelist;
			    		if(pricelist.success) {
			    			for(id = 0; id < invIndexes.length; id++) {
			    				var index = invIndexes[id];
			    				var item = data.rgDescriptions[data.rgInventory[index].classid+"_"+data.rgInventory[index].instanceid];
			    				if(item.tradable != 1) {
			    					continue;
			    				}
				    			var itemName = item.market_hash_name; 
				    			var iconUrl = item.icon_url;
				    			
                  if(pricelist.items[itemName] && pricelist.items[itemName].volume >= 10) {
                    var price = Math.round(Number(pricelist.items[itemName].median_price) * 1000);
                    console.log(itemName);
                    console.log(price);
                    if(price >= 1) {
                      prices[itemName] = price;
                      items[id] = {name:itemName, price:price, iconurl: iconUrl, classid: data.rgInventory[index].classid, id: index, done:true};
                    } else {
                      items[id] = {done:true};
                    }
                  } else {
                      items[id] = {name:itemName, price:0, iconurl: iconUrl, classid: data.rgInventory[index].classid, id: index, done:false};
                  }
			    			}
			    			finishedLoading();
			    		}
			    	});
					} else {
						$("#loading").remove();
    		    $("#withdraw-button").remove();
						if(data.Error == "This profile is private.") {
							$("#status").addClass("red-text").removeClass("green-text").html("Error: The bot's inventory is private. Please let a mod/admin know.");
						} else {
							$("#status").addClass("red-text").removeClass("green-text").html("An unknown error occurred");
						}
					}
    		});
    	}

    	function finishedLoading() {
        var notDoneItems = 0;
        items.forEach(function(item, id, arr) {
          if(!item.done) {
            notDoneItems++;
            $.getJSON("http://csgosnaffy.com/getItemPrice.php?market_hash_name="+item.name.replace("\u2605", "{STAR}").replace("\u2122","{TM}"), function(data) {
              if(data.success) {
                console.log(id);
                items[id].price = Math.round(Number(data.median_price) * 1000);
                prices[items[id].name] = Math.round(Number(data.median_price) * 1000);
              }
              notDoneItems--;
            });
          }
        });

        var intervalthing = setInterval(function() {
          if(notDoneItems == 0) {
            items.sort(function(a,b){
              return b.price-a.price;
            });
            $("#inv_container").html($("#inv_container").html()+'<ul class="row" id="inventory" data-animation="hierarchical-display"></ul>');
            items.forEach(function(item, index, arr) {
              if(item.price != undefined) {
                $("#inventory").html($("#inventory").html()+"<li class='col s2' style='padding:1%;'><div class='card item-card waves-effect waves-light hoverable' style='margin:0;' id='"+item.id+"'><div class='card-content center-align' style='padding:6%'><img title=\""+item.name+"\" draggable='false' src='http://steamcommunity-a.akamaihd.net/economy/image/"+item.iconurl+"/' style='width:100%;height:auto;'>"+numberWithCommas(item.price)+" Coins</div></div></li>");
              }
            });
            $("#loading").remove();
            $('#inventory').hierarchicalDisplay('show');

            $(".item-card").mousedown(function() {
              $(this).toggleClass("red lighten-1 white-text selected-item");

              calculateTotal();
            });
            clearInterval(intervalthing);
          }

        }, 100);
    	}

    	var totalCoins = 0;

    	function calculateTotal() {
    		totalCoins = 0;

    		$(".selected-item").each(function() {
    			var value = Number(prices[$(this).find("img").attr("title")]);
    			totalCoins += value;
    		});
    		$("#coins-amt").text(numberWithCommas(totalCoins));
        if(totalCoins == 0) {
          $('#withdraw-button').addClass('disabled');
        } else {
          $('#withdraw-button').removeClass('disabled');
        }
    	}

    	function withdraw() {
    		if(totalCoins <= 0) {
    			return;
    		}
    		var query_items = [];
    		$(".selected-item").each(function() {
    			query_items.push([$(this).attr('id'), $(this).find('img').attr('title').replace('\u2605','{STAR}').replace('\u2122','{TM}')]);
    		});
    		$.getJSON("http://csgosnaffy.com/addBotTask.php?type=withdraw&steamid="+steamid+"&value="+totalCoins+"&items="+JSON.stringify(query_items), function(data) {
    			if(data.success) {
            if(data.info == 'adminApproval') {
    				  $("#status").removeClass("red-text").addClass("gold-text").html("This offer must be approved by an administrator before being sent. If approved, your trade will be sent at the soonist possible oppertunity. Please do not request any more offers for at least a few hours to give our admins a chance to respond.");
    				} else {
              $("#status").removeClass("red-text").addClass("green-text").html("Success~ your coins will be deducted as soon as bot sends you a trade offer. Do not decline the trade offer. Your coins will be lost and will not be returned.");
            }
            $("#withdraw-button").remove();
    			} else {
    				if(data.reason == "invalid_tradeurl") {
    					$("#withdraw-button").remove();
	    				$("#status").addClass("red-text").removeClass("green-text").html("Invalid Trade URL, please go to settings and set your trade url.");
    				} else if(data.reason == "value_mismatch") { 
              $("#status").addClass("red-text").removeClass("green-text").html("<br />Item value mismatch, please refresh the page and try again.");
            } else if(data.reason == "insufficient_balance") { 
              $("#status").addClass("red-text").removeClass("green-text").html("<br />Your Balance is insufficient for this transaction.");
            } else if(data.reason == "blacklisted") { 
              $("#withdraw-button").remove();
              $("#status").addClass("red-text").removeClass("green-text").html("You have been blacklisted from withdrawing.");
            } else if(data.reason == "access_denied") {
              $("#withdraw-button").remove();
              $("#status").addClass("red-text").removeClass("green-text").html("Access Denied, please try relogging.");
            } else if(data.reason == "deposit") {
              $("#withdraw-button").remove();
              $("#status").addClass("red-text").removeClass("green-text").html("You must deposit at least $5 before withdrawing.");
            } else {
              $("#status").addClass("red-text").removeClass("green-text").html("<br />Something went wrong :(");
	    			}
    			}
    		});
    	}

    	loadItems('<?php echo $_SESSION["steamid"];?>');
      function numberWithCommas(x) {
        return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
      }
          // Materialize.toast("<span class='red-text'>Deposit/Withdraw bots are currently offline.</span>", 10000);