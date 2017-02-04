
    var confirmLeave = function() {
      return "If you leave any bets you have placed will be lost and your coins will not be returned.";
    }
    var notify = new Audio('/sound/notify.wav');
    notify.volume = 0.25;
    
    var ding = new Audio('/sound/ding.wav');
    ding.volume = 0.25;

    var mboxStart = new Audio('/sound/MysteryBoxStart.wav');
    mboxStart.volume = 1;

    var mboxEnd = new Audio('/sound/MysteryBoxDone.wav');
    mboxEnd.volume = 1;

    function sendcash(steamid) {
      $('.ctxMenu').remove();
      $("#chatMessage").val("/send "+steamid+" ");
    }
    function mute(steamid) {
      $('.ctxMenu').remove();
      $("#chatMessage").val("/mute "+steamid+" ");
    }
    function unmute(steamid) {
      $('.ctxMenu').remove();
      $("#chatMessage").val("/unmute "+steamid+" ");
    }
    var loggedinn = false;
    var streamers;
    var steamid;
    $(document).ready(function() {
      function escapeStr(str) {
        $("#escape").text(str);
        var escaped = $("#escape").html();
        $("#escape").html("");
        return escaped;
      }

      var currentCountdown = 0;
      var wheelSVG = $();
      var spinner = $();
      var center = $();
      var centerText = $();

      loggedinn = $("#loggedin").text() == 'true';
      var avatar = $("#avatar").html();
      steamid = $("#steamid").html();
      var name = $("#name").html();
      var signupdate = $("#signupdate").html();
      var logintime = $("#logintime").html();
      var salt = $("#salt").html();
      streamers = JSON.parse($("#referrers").html());
      var ismod = $("#mod").text() == 'true';

      var scrollChat = false;

      var beforeLoginSpinInterval;

      var brown = {fill: "#6d4c41"};
      var red = {fill: "#02639C!important"};
      var green = {fill: "#F44336!important"};
      var black = {fill: "#212121"};

      var ctxMenuTimeout = 0;

      var flips = {};

      var curMboxPercent = -15;
      var cur = curMboxPercent;

      $("object").load(function() {
        wheelSVG = $("object").contents().find("svg");
        spinner = spinner.add(wheelSVG.find("#spin"));
        center = wheelSVG.find("#ui ellipse");
        centerText = wheelSVG.find("#number");
        clearInterval(beforeLoginSpinInterval);
        if(!loggedinn) {
          beforeLoginSpinInterval = setInterval(function() {
            currentRotation += 0.25;
            spinner.css("transform", 'rotate('+currentRotation+'deg)');
          }, 20);
        }
      });
      setTimeout(function() {
        wheelSVG = $("object").contents().find("svg");
        spinner = spinner.add(wheelSVG.find("#spin"));
        center = wheelSVG.find("#ui ellipse");
        centerText = wheelSVG.find("#number");
        clearInterval(beforeLoginSpinInterval);
        if(!loggedinn) {
          beforeLoginSpinInterval = setInterval(function() {
            currentRotation += 0.25;
            spinner.css("transform", 'rotate('+currentRotation+'deg)');
          }, 10);
        }

        $('.wheel').click(function() {
          $('.free-coins-card').stop().animate({top:'-35%'}, 500, 'easeInCirc');
        });
      }, 2000);

      var connected = false;

        var cdInterval;
        var rollDegrees = [24*1, 24*3, 24*5, 24*7, 24*9, 24*11, 24*13, 24*2, 24*4, 24*6, 24*8, 24*10, 24*12, 24*14, 0].reverse();

        var rollNumber = 0;

        var currentRotation = 0;

        var balance = 0;
        var cdTimeout;
        var originalCountdown = 0;

        var barInterval;
        var updateTotals = true;
        var shouldPlayClick = false;

      if(loggedinn) {
              var mysocket = new WebSocket("wss://213.159.215.102:3103", "roulette");
        $('#login').hide();

        mysocket.onopen = function(event) {
          console.log("CSGO DARK 2016 ®");
          $("#chat").html($("#chat").html() + "\n<div class=\"green-text\"><i>Connected!</i></div>");
          $("#chat").html($("#chat").html() + "\n<div class=\"blue-text\"><i><b>Rules: 1. No Begging. 2. English ONLY 3. No code sharing. 4. No advertising. 5. No harassment. 6. You agree that csgosnaffy.com is not liable for any coins lost due to network error. (Do not ask for your coins back)<b></i></div>");
          $("#chat").html($("#chat").html() + "\n<div class=\"green-text\"><i>Generating authentication token.</i></div>");
          var token = SHA256.hash(steamid+"-"+signupdate+"-"+logintime+"-"+salt);
          var authPacket = JSON.stringify({type:"auth", steamid:steamid, token: token, name:name, avatar:avatar});
          mysocket.send(authPacket);
          $("#bet-card").show();
          $("#topbets-card").show();
          clearInterval(beforeLoginSpinInterval);
          connected = true;
        }

        mysocket.onmessage = function(event) {
          var data = JSON.parse(event.data);

          if(data.type=="roll") {
            clearInterval(cdInterval);
            connected = true;

            $("#status").html('Rolling!');
            center.css(brown);

            roll(data.roll, data.offset)
            clearInterval(barInterval);
            currentCountdown = 0;
            originalCountdown = 0;
              $(".determinate").css({width: "0%"});

            setTimeout(function(){
              $("#status").text("ROLLED "+data.roll+"!");
        if(!$("#mute").is(":checked")){
              ding.play();}

              var cla = data.roll == 0 ? green : ((data.roll >= 1 && data.roll <= 7) ? black : red);

              $(".determinate").animate({width: "100%"}, 500, "easeOutQuad");
              var totalGreen = Number($("#green-total").prop('val'));
              var totalRed = Number($("#red-total").prop('val'));
              var totalBlack = Number($("#black-total").prop('val'));

              $("#green-total").html("<span class='red-text'>-"+totalGreen+"</span>");
              $("#red-total").html("<span class='red-text'>-"+totalRed+"</span>");
              $("#black-total").html("<span class='red-text'>-"+totalBlack+"</span>");

              $("#my-green-bet").html("0");
              $("#my-red-bet").html("0");
              $("#my-black-bet").html("0");

              updateTotals = false;

              setTimeout(function() {
                updateTotals = true;
              }, 1600);

              if(cla == green) {
                $("#green-total").stop().animate({val:totalGreen*14}, {duration:750, easing:'swing', 
                  step: function(now) {
                    $(this).html("<span class='green-text'>+"+numberWithCommas(Math.floor(Number(now)+0.5))+"</span>");
                  }
                });
                $("#black-total").stop().animate({val:(-totalBlack)}, {duration:750, easing:'swing', 
                  step: function(now) {
                    $(this).html("<span class='red-text'>"+numberWithCommas(Math.floor(Number(now)+0.5))+"</span>");
                  }
                });
                $("#red-total").stop().animate({val:(-totalRed)}, {duration:750, easing:'swing', 
                  step: function(now) {
                    $(this).html("<span class='red-text'>"+numberWithCommas(Math.floor(Number(now)+0.5))+"</span>");
                  }
                });
              }
              if(cla == red) {
                $("#red-total").stop().animate({val:totalRed*2}, {duration:750, easing:'swing', 
                  step: function(now) {
                    $(this).html("<span class='green-text'>+"+numberWithCommas(Math.floor(Number(now)+0.5))+"</span>");
                  }
                });
                $("#black-total").stop().animate({val:(-totalBlack)}, {duration:750, easing:'swing', 
                  step: function(now) {
                    $(this).html("<span class='red-text'>"+numberWithCommas(Math.floor(Number(now)+0.5))+"</span>");
                  }
                });
                $("#green-total").stop().animate({val:(-totalGreen)}, {duration:750, easing:'swing', 
                  step: function(now) {
                    $(this).html("<span class='red-text'>"+numberWithCommas(Math.floor(Number(now)+0.5))+"</span>");
                  }
                });
              }
              if(cla == black) {
                $("#black-total").stop().animate({val:totalBlack*2}, {duration:750, easing:'swing', 
                  step: function(now) {
                    $(this).html("<span class='green-text'>+"+numberWithCommas(Math.floor(Number(now)+0.5))+"</span>");
                  }
                });
                $("#red-total").stop().animate({val:(-totalRed)}, {duration:750, easing:'swing', 
                  step: function(now) {
                    $(this).html("<span class='red-text'>"+numberWithCommas(Math.floor(Number(now)+0.5))+"</span>");
                  }
                });
                $("#green-total").stop().animate({val:(-totalGreen)}, {duration:1000, easing:'swing', 
                  step: function(now) {
                    $(this).html("<span class='red-text'>"+numberWithCommas(Math.floor(Number(now)+0.5))+"</span>");
                  }
                });
              }
              center.css(cla);

              var pastRolls = $("#past-rolls");
              var c = data.roll == 0 ? green.fill : ((data.roll >= 1 && data.roll <= 7) ? "#424242" : red.fill);

              pastRolls.html(pastRolls.html()+"<div style=\"background-color:"+c+"; padding-top: 1%;\" class=\"white-text valign-wrapper past-roll\">"+data.roll+"</div>");

              if(pastRolls.find("div").length > 10) {
                pastRolls.find("div").animate({left: ""+(-pastRolls.width()*0.1+0.5)+"px"},1000,"easeOutQuad", function() {
                  $(this).css({left: "0.5px"});
                });
                setTimeout(function() {
                  pastRolls.find("div")[0].remove();
                }, 1000);
              }
            }, 9000);
          }

          if(data.type=="countdown") {
            $(window).unbind("beforeunload");
            currentCountdown = (data.countdown-1);

            $("#status").html('Countdown to Roll: <span id="countdown"></span> seconds');
            $(".betbtn").prop('disabled', false);
            $("#betamt").prop('disabled', false);
            $(".determinate").removeClass("red green grey darken-3").addClass("grey");
            $(".progress").removeClass("red green grey lighten-1 lighten-4").addClass("grey lighten-4");

            $("#countdown").text(currentCountdown.toFixed(2));

            clearInterval(cdInterval);
            clearInterval(barInterval);
            if(originalCountdown < (data.countdown-1)) {
              originalCountdown = (data.countdown-1);
            }
            cdInterval = setInterval(function() {
              currentCountdown-=0.025;
              $("#countdown").text(currentCountdown.toFixed(2));
              if(currentCountdown <= 0) {
                clearInterval(cdInterval);
                clearInterval(barInterval);
                $("#status").html('Confirming Bets');
        if(!$("#mute").is(":checked")){
                notify.play();
              }
              $(".determinate").css("width","0%");
              }
            },25);
            barInterval = setInterval(function() {
              $(".determinate").css("width",(currentCountdown/originalCountdown)*100+"%");
            }, 10);
          }

          if(data.type=="balance"){
            balance = data.balance;
            $("#balance").text(numberWithCommas(balance));
          }
          if(data.type=="updateBalance"){
            balance += data.balUpdate;
            $("#balance").text(numberWithCommas(balance));
          }

          if(data.type=="betConfirm"){
            $(window).bind("beforeunload", confirmLeave);
            var color = data.color;
            var amount = data.amount;
            $("#my-"+data.color+"-bet").text(numberWithCommas(data.amount));
            $(".determinate").removeClass("red green grey darken-3").addClass(data.color == "black" ? "grey darken-3" : data.color);
            $(".progress").removeClass("red green grey lighten-1 lighten-4").addClass(data.color == "black" ? "grey lighten-1" : data.color + " lighten-4");
            $(".betbtn").prop('disabled', false);
            $("#betamt").prop('disabled', false);
          }

          if(data.type=="betTotals" && updateTotals) {
            for(color in data.bets) {
              $("#"+color+"-total").stop().animate({val:data.bets[color]}, {duration:1000, easing:'swing', 
                step: function(now) {
                  $(this).text(numberWithCommas(Math.floor(Number(now)+0.5)));
                }
              });
            }
          }

          if(data.type=="topBets") {
            for(color in data.bets) {
              $("#"+color+"-bets").html("");
              for(id in data.bets[color]) {
                $("#"+color+"-bets").html($("#"+color+"-bets").html() + '<br /><div class="divider"></div><span class="truncate">'+data.bets[color][id].name +'</span>' + numberWithCommas(data.bets[color][id].amount));
              }
            }
          }

          if(data.type=="chat"){
            switch(data.messagetype) {
              case "alert-info":
                $("#chat").html($("#chat").html() + "\n<div class=\"green-text\"><i>" + escapeStr(data.message) + "</i></div>");
              break;
              case "alert-danger":
                $("#chat").html($("#chat").html() + "\n<div class=\"red-text\"><b><i>" + escapeStr(data.message) + "</i></b></div>");
              break;
              case "playerchat":
                if(data.steamid == "76561198167523241") {
                  data.player = "<span class=\"red-text\">[OWNER] "+data.player+"</span>";
				} else  if(data.steamid == "76561198194153457") {
                  data.player = "<span class=\"red-text\">[CO-OWNER] "+data.player+"</span>";
                } else if(data.steamid == "STEAMID?") {
                  data.player = "<span class=\"pink-text text-lighten-1\">[ADMIN] "+data.player+"</span>";
                } else if(data.steamid == "STEAMID?") {
                  data.player = "<span class=\"black-text\" >[Admin] "+data.player+"</span>";
                } else if(data.steamid == "76561198183784993") {
                  data.player = "<span class=\"green-text text-darken-4\">[PRG] "+data.player+"</span>";
                } else if(data.steamid == "") {
                  data.player = "<span class=\"blue-text text-darken-3\">[ADMIN] "+data.player+"</span>";
                } else if(data.steamid == "") {
                  data.player = "<span class=\"deep-purple-text\">[Bro] "+data.player+"</span>";
                } else if(data.steamid == "") {
                  data.player = "<span class=\"amber-text text-darken-1\">[Veteran] "+data.player+"</span>";
                } else if(data.mod) {
                  data.player = "<span class=\"lightblue-text\">[MOD] "+data.player+"</span>";
				
                } else {
                  data.player = "<span class=\"black-text\">"+data.player+"</span>";
                }

                $("#chat").html($("#chat").html() + ('\n<div><a href="javascript:void(0)" class="chatimglnk" steamid="'+data.steamid+'"><img src="'+data.avatarurl+'" class="chat-image"></a> <a class="chat-link" href="http://steamcommunity.com/profiles/'+data.steamid+'"><b>'+data.player + '</b></a>: ' + escapeStr(data.message) + '</div>').replace(/Kappa/g,'<img src="//static-cdn.jtvnw.net/emoticons/v1/25/1.0" title="Kappa" alt="Kappa" channel="undefined" style="display: inline; width: auto; overflow: hidden;">'));

                
              break;
              default: break;
            }
            $(".chatimglnk").click(function(e) {
                  $(".ctxMenu").remove();
                  clearTimeout(ctxMenuTimeout);
                  var me = $(this);
                  if(ismod) {
                  $("body").append(
                        "'"+
                        '<div class="ctxMenu" style="left:'+e.pageX+'px; top:'+e.pageY+'px;">'+
                        '<ul>'+
                        '<a href="javascript:void(0)" onclick="sendcash(\''+me.attr("steamid")+'\')"><li>Send Coins</li></a>'+
                        '<a href="javascript:void(0)" onclick="mute(\''+me.attr("steamid")+'\')"><li>Mute Player</li></a>'+
                        '<a href="javascript:void(0)" onclick="unmute(\''+me.attr("steamid")+'\')"><li>Unute Player</li></a>'+
                        '</ul>'+
                        '</div>'+
                        "'");
                } else {
                  $("body").append(
                        "'"+
                        '<div class="ctxMenu" style="left:'+e.pageX+'px; top:'+e.pageY+'px;">'+
                        '<ul>'+
                        '<a href="javascript:void(0)" onclick="sendcash(\''+me.attr("steamid")+'\')"><li>Send Coins</li></a>'+
                        '</ul>'+
                        '</div>'+
                        "'");
                }
                  ctxMenuTimeout = setTimeout(function() {
                    $(".ctxMenu").remove();
                  }, 2000);
                });
            if(!$("#chatpause").is(":checked")){
              $("#chat").stop();
              $("#chat").animate({ scrollTop: $("#chat")[0].scrollHeight - $("#chat").height() }, 1000 + scrollChat * 2^30, "easeOutCirc", function() {
                while($("#chat").find("div").length > 50) {
                  $("#chat").find("div")[0].remove();
                }
              });
            }
          }
          if(data.type=="usercount") {
            $("#online").text(data.count)
          }
          if(data.type=="coinflip-create-confirm") {
            coinToast(numberWithCommas(data.wager));
          }
          if(data.type=="coinflips") {
            setTimeout(function() {
              $("#fliptable-body").html("");
              flips = data.flips;
              for(id in flips) {
                $("#fliptable-body").html(
                    $("#fliptable-body").html() +
                    '<tr id="'+id+'-cfliprow">'+
                    '<td><img class="chat-image" src="'+flips[id].avatar+'">&nbsp;'+flips[id].name+'</td>'+
                    '<td>'+numberWithCommas(flips[id].wager)+' Coins</td>'+
                    '<td class="right-align"><button id="'+id+'-cflipbutton" sid="'+id+'" class="modal-trigger coinflip-start btn green waves-effect waves-light">Challenge!</buton></td>'+
                    '</tr>'
                  );
                if(balance < flips[id].wager || id == steamid) {
                  $("#"+id+"-cflipbutton").prop('disabled', true);
                }
              }
              $(".coinflip-start").click(function() {
                var id = $(this).attr('sid');
                console.log(id);
                mysocket.send(JSON.stringify({type:"joinCFlip", wager:flips[id].wager, challenger: id}));
              });
            },500);
          }
          if(data.type=="coinflip-start") {
            $(".toast").remove();
            $("#cf-modal").html('<div class="modal-content"><h4>Coin flip with <span id="coinflip-partner"></span> for <span id="coinflip-wager"></span></h4><h5>You are <span id="coinflip-team"></span></h5><div class="center-align">'+
              '<div id="coin-flip-cont">'+
              '<div class="coin-shadow"></div><div id="coin">'+
              '<div class="front"></div>'+
              '<div class="back"></div>'+
              '</div>'+
              '</div><br />'+
              '<h4 id="coinflip-status">Flipping in <span id="cflip-cd"></span> seconds</h4></div>');
            var myteam = data.player == "ct" ? "Counter-Terrorists" : "Terrorists";
            $("#coinflip-partner").html(data.othername);
            $("#coinflip-team").text(myteam);
            $("#coinflip-wager").text(numberWithCommas(data.wager));
            setTimeout(function() {
              $("#cf-modal").openModal({dismissible: false});
            }, 50);

            $({countdown: 5}).animate({countdown:0},{
              duration: 5000,
              easing: "linear",
              step:function(now) {
                $("#cflip-cd").text(now.toFixed(2));
              }
            });
          }
          if(data.type=="coinflip-winner") {
            var winner = data.winner == "ct" ? "Counter-Terrorists" : "Terrorists";
            $("#coinflip-status").text("Flipping...");
            $({deg: 0}).animate({deg:360*5 + 180 * (data.winner=="ct")},{
              duration: 10000,
              easing: "easeOutCubic",
              step:function(now) {
                $("#coin").css({transform: 'rotateY(' + now + 'deg)'});
                $(".coin-shadow").css({width: ''+(Math.abs(Math.cos((now-35)*(Math.PI/180))) * 256) + 'px'});
              }
            });
            setTimeout(function() {
              $("#coinflip-status").text(winner + " win.");
              mysocket.send(JSON.stringify({type:"cflipBal"}));
              setTimeout(function() {
                $("#cf-modal").closeModal();
              }, 1500);
            }, 10000);
          }
        }
        
        function roll(num, offset) {
          rollNumber+=1;
          var angle = rollNumber*360*4+rollDegrees[num]+offset;
          $({deg: currentRotation}).animate({deg: angle}, {
              duration: 9000,
              easing: $.bez([0.2,1,0.2,1]),
              step: function(now) {
                  spinner.css({
                      transform: 'rotate(' + now + 'deg)'
                  });
                  currentRotation = now;
              }
          });
          $(".betbtn").prop('disabled', true);
          $("#betamt").prop('disabled', true);
        }
        $("#refreshBalance").click(function(){
          mysocket.send(JSON.stringify({type:"balanceReq"}));
        });

        $('#flip-submit').click(function() {
          var wager = 0;
          if($("#flipwager").val() && (wager = Number($("#flipwager").val())) != NaN) {
            mysocket.send(JSON.stringify({
              type: "chat",
              message: "/flip "+wager
            }));
            $("#new-cf-modal").closeModal();
          }
        });

        $(".betbtn").click(function(){
          var color = $(this).attr("color");
          var amount = Number($("#betamt").val());
          if(amount != NaN && amount > 0) {
            $(".betbtn").prop('disabled', true);
            $("#betamt").prop('disabled', true);
            mysocket.send(JSON.stringify({type:"bet", color:color, amount:Math.floor(amount)}));
          } else {
            $("#chat").html($("#chat").html() + "\n<div class=\"red-text\"><b><i>Invalid Bet Amount</i></b></div>");
            $("#chat").stop();
            $("#chat").animate({ scrollTop: $("#chat")[0].scrollHeight - $("#chat").height() }, 1000, "easeOutCirc", function(){
              while($("#chat").find("div").length > 50) {
                $("#chat").find("div")[0].remove();
              }
            });
          }
        });

      } else {

      }
        var angle = 0;
      var numberOrder = [1,8,2,9,3,10,4,11,5,12,6,13,7,14,0].reverse();

      $("#chatForm").on("submit", function() {
        var msg = $("#chatMessage").val();
        if(msg.toLowerCase().startsWith("/cancelflip")) {
          $(".toast").remove();
        }
        if(msg && connected) {
          mysocket.send(JSON.stringify({
            type:"chat",
            message:msg
          }));
        }
        $("#chatMessage").val("");
        return false;
      });
      var lastNumber = 0;
      var curNum = 0;
      setInterval(function(){
            var angle = currentRotation + 12;
            angle%=360;
            curNum = numberOrder[Math.floor(angle/24)];
            centerText.text(curNum);
            if(!loggedinn) {
              var cla = curNum == 0 ? green : ((curNum >= 1 && curNum <= 7) ? black : red);

              center.css(cla);
            }
            $("#past-rolls").css("height", $("#past-rolls").width()/10);
            $(".past-roll").css("font-size", $(".past-roll").width()*(1/2));
      },5);
      var abcdefg = 0;
      var abcdefg2 = 0;
      setInterval(function() {
        if(!$("#mute").is(":checked")){
              if(loggedinn && lastNumber != curNum && abcdefg2 >= 5) {
                lastNumber = curNum;
                var a = new Audio('/sound/clack5.wav');
                a.volume = 0.25;
                a.play();
                abcdefg2 = 0;
              }
              if(shouldPlayClick && abcdefg >= 17) {
                var a = new Audio('/sound/MysteryBoxClick.wav');
                a.volume = 1;
                a.play();
                shouldPlayClick = false;
                abcdefg = 0;
              }
              abcdefg += 1;
              abcdefg2 += 1;
            }
        $('.item-card').css("width",$('.mysterybox-spinner').width()*.2+"px");
        $('.item-card').css("height",$('.item-card').width()+"px");
        $('.item-card').css("font-size",$('.item-card').width()*.13+"px");
      }, 10);
      function numberWithCommas(x) {
        return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
      }

      $("#snowtoggle").click(function() {
        if($(this).is(":checked")) {
          $("#snowflakeContainer").css({display:"none"});
          setUpdateSnow(false);
        } else {
          $("#snowflakeContainer").css({display:"block"});
          setUpdateSnow(true);
        }
      });

      var chatOpen = true;

      $("#chatToggle").click(function() {
        if(chatOpen) {
          $("#chat-col").stop().animate({left: "-120%"}, 500, "easeInCubic");
          $(".main-card").parent().stop().animate({left:"4.1666666667%", width: "91.666666667%"}, 800, "easeInOutCubic");
          $("#chat-toggle-icon").css({transform: "rotate(90deg)"});
          $("#chatToggle").stop().animate({left: "3.291%"}, 800, "easeInOutCubic");
          chatOpen = false;
        } else {
          setTimeout(function(){
              $("#chat-col").stop().animate({left: "0"}, 500, "easeOutCubic");
          }, 300);
          $(".main-card").parent().stop().animate({left: '25%', width: "75%"}, 800, "easeInOutCubic");
          $("#chat-toggle-icon").css({transform: "rotate(-90deg)"});
          $("#chatToggle").stop().animate({left: "24.125%"}, 800, "easeInOutCubic");
          chatOpen = true;
        }
      });
      $(".button-collapse").sideNav();
          $("#free-coins-loading").hide();
      $("#refcode-submit").click(function(){
        var refcode = $('#code').val();
        if(refcode.length == 8) {
          $("#free-coins-loading").show();
          $(this).hide();
          $.getJSON("http://213.159.215.102/freeCoins.php?steamid="+steamid+"&refcode="+refcode, function(data) {
              $("#free-coins-loading").hide();
              if(data.success) { 
                $("#code").val("Success, 250 coins have been added!");
              } else {
                if(data.reason == "error") {
                  $("#code").val("An error occurred.");
                }
                if(data.reason == "used") {
                  $("#code").val("You have already used a code!");
                }
                if(data.reason == "own") {
                  $("#code").val("You cannot use your own code.");
                }
                if(data.reason == "invalid") {
                  $("#code").val("That is an invalid code.");
                }
              }
          });
        }
      });
      if(loggedinn) {
        $("#nav-mobile").html('<li><a href="#freecoins" class="modal-trigger waves-effect waves-light">Free Coins!</a></li>' + $("#nav-mobile").html());
        $("#mobile-nav").html('<li><a href="#freecoins" class="modal-trigger waves-effect waves-light">Free Coins!</a></li>' + $("#mobile-nav").html());
        $("#nav-mobile").html($("#nav-mobile").html() + '<li><a href="javascript:void(0)" onclick="tutorial()" class="waves-effect waves-light">Help</a></li>');
        $("#mobile-nav").html($("#mobile-nav").html() +'<li><a href="javascript:void(0)" onclick="tutorial()" class="waves-effect waves-light">Help</a></li>');
      }
      $('.modal-trigger').leanModal();

      var totalProfit = 0;
      $('#mysterybox-button').click(function() {
		  $('#mysterybox-button').hide();
            $("#mbox-status").text("Please wait...");
      rainbow();     
        $.getJSON('http://213.159.215.102/mysteryBox.php', function(data) {
          if(data.success) {
            $("#mbox-status").text("Spinning...");
            var i = 0;
            $(".mbox-coinamt").each(function(){
              $(this).text(numberWithCommas(data.values[i]));
              if(data.values[i] == 100000) {
                $(this).parent().removeClass("blue purple deep-purple red darken-4 accent-3 amber rainbow").addClass("rainbow");
              } else if(data.values[i] >= 50000) {
                $(this).parent().removeClass("blue purple deep-purple red darken-4 accent-3 amber rainbow").addClass("amber");
              } else if(data.values[i] >= 20000) {
                $(this).parent().removeClass("blue purple deep-purple red darken-4 accent-3 amber rainbow").addClass("red");
              } else if(data.values[i] >= 8000) {
                $(this).parent().removeClass("blue purple deep-purple red darken-4 accent-3 amber rainbow").addClass("purple accent-3");
              } else if(data.values[i] >= 2000) {
                $(this).parent().removeClass("blue purple deep-purple red darken-4 accent-3 amber rainbow").addClass("deep-purple");
              } else {
                $(this).parent().removeClass("blue purple deep-purple red darken-4 accent-3 amber rainbow").addClass("blue darken-4");
              }
              i++;
            });
            $(".mysterybox-container").show();
            $('#mysterybox-button').hide();
            cur = -13;
            $(".item-card").stop().css({right:"-15%"}).animate({right: 87.72 + Math.abs(Math.random()*1.76) + "%"}, {
                duration: 12000,
                easing: "easeOutCubic",
                step: function(now) {
                  if(cur + 2.25 < now) {
                    shouldPlayClick = true;
                    cur = now;
                  }
                },
                complete: function() { 
                  $('#mysterybox-button').show();
                  $("#mbox-status").text("You won "+numberWithCommas(data.values[46])+" coins!");
                }});
            setTimeout(function() {
              mysocket.send(JSON.stringify({type:"cflipBal"}));
              if(data.values[46] >= 25000) {
                mysocket.send(JSON.stringify({type:"mbox-bigwin", amount:data.values[46]}));
              }
              mboxEnd.play();
            }, 12000);
            mboxStart.play();
          } else if(data.reason == "insufficient_balance") {
            $('#mysterybox-button').show();
            $("#mbox-status").text("You need 2,500 coins for this!");
          }
        });
      })
       
          // Materialize.toast("<span class='red-text'>Deposit/Withdraw bots are currently offline.</span>", 10000);
    });
  function coinToast(wager) {
    var toastInner = '<div class="preloader-wrapper small active"><div class="spinner-layer spinner-blue"><div class="circle-clipper left"><div class="circle"></div></div><div class="gap-patch"><div class="circle"></div></div><div class="circle-clipper right"><div class="circle"></div></div></div><div class="spinner-layer spinner-red"><div class="circle-clipper left"><div class="circle"></div></div><div class="gap-patch"><div class="circle"></div></div><div class="circle-clipper right"><div class="circle"></div></div></div><div class="spinner-layer spinner-yellow"><div class="circle-clipper left"><div class="circle"></div></div><div class="gap-patch"><div class="circle"></div></div><div class="circle-clipper right"><div class="circle"></div></div></div><div class="spinner-layer spinner-green"><div class="circle-clipper left"><div class="circle"></div></div><div class="gap-patch"><div class="circle"></div></div><div class="circle-clipper right"><div class="circle"></div></div></div></div>';
    toastInner += "&nbsp;&nbsp;&nbsp;&nbsp;Waiting for coinflip partner for "+wager+" coins.";
    Materialize.toast(toastInner);
  }
  var spinInterval = 0;

  function rainbow() {
    var rainbowPos = 0;
    clearInterval(spinInterval);
    spinInterval = setInterval(function() {
      rainbowPos += 5;
      $(".rainbow").css("background-position", "0 "+rainbowPos+"px");
      if(rainbowPos > $(".item-card").height) {
        rainbowPos = 0;
      }
    }, 16.667);
  }

  function tutorial() {
    $('body').scrollTo("#bet-card", {offsetTop:400});
    Materialize.toast("This is where you can place bets on different colors.<br /> Winning on red or black will give you 2x your money back.<br /> Winning on green will give you 14x your money.");
    $("#bet-card").spotlight({onHide:function(){
      $(".toast").remove();
      $('body').scrollTo("#topbets-card", {offsetTop:400});
      Materialize.toast("This is where you can see what other people have bet on each color.");
      $("#topbets-card").spotlight({onHide:function(){
        $(".toast").remove();
        $('body').scrollTo(".chat-card", {offsetTop:400});
        Materialize.toast("Talk to people here, please be sure to review the chat rules.");
        $(".chat-card").spotlight({onHide:function(){
          $(".toast").remove();
          $('body').scrollTo(".cflip-card", {offsetTop:400});
          Materialize.toast("You have a 50% chance to double your money by doing a coin flip against another player.");
          $(".cflip-card").spotlight({onHide:function(){
            $(".toast").remove();
            Materialize.toast("Here you can open a mystery box, you have a chance of winning up to 100,000 coins!");
            $("#mysterybox-modal").openModal({complete:function(){
              $(".toast").remove();
              Materialize.toast("Have fun and good luck!", 5000);
            }});
          }});
        }});
      }});
    }});
  }

  function replaySpin() {
    $(".item-card").stop().css({right:"-15%"}).animate({right: 87.72 + Math.abs(Math.random()*1.76) + "%"}, {
                duration: 12000,
                easing: "easeOutCubic",
                complete: function() { 
                  $('#mysterybox-button').show();
                  $("#mbox-status").text("You won "+numberWithCommas(data.values[46])+" coins!");
                }});
  }