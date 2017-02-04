var io = io.connect('http://csgosnaffy.com:3000', {secure: true});
var interval;
var intervalrunning=false;
var userid2;

 console.log("CSGOSNAFFY 2016 ®");
function cc(userid2){
	//userid2=Number(userid2);

	if(userid2 in ccs){
		return '&nbsp;<a href="'+ccs[userid2].url+'" target="_blank" title="'+ccs[userid2].title+'"><img src="'+ccs[userid2].icon+'" alt="[#]"/></a>';
	}else{
		return'';
	}
}



	$('#test').click(function(){
		
				$.ajax({
					type: "GET",
					url: "loadr.php",
					success: function(msg){
								     $('.kjmhgd').show(500);
		      $(".kjmhgd").html(msg);	        
					
					}
				});
		  });

$(document).ready(function(){

	        	//var height = Math.max($("#chat").height(), $("#sidebar").height(), $("#content").height());
		        //$("#sidebar").height(heisght);
		       //$("#content").height(height);


	var gettimeleft=parseInt($('div#timeleft').text());
	//console.log(gettimeleft);
	var timeleft=parseInt(gettimeleft);
	if(timeleft<maxtimer){
		if(intervalrunning!==true){
			interval = setInterval(updatetimer, 1000); //game already running, start timer
		}else{
			console.log('interval already set...');
		}
	}

	var userid=$('#userid').text();
    
	var grid = $('.grid').isotope({
	  // options
	  layoutMode: 'horizontal',
	  itemSelector: '.item',
	  sortAscending: false,
	  sortBy: 'cost',

	  getSortData: {
		'cost': '.sortcost',
		'quality': '[data-quality]',
		}
	});
    
	
	var playersgrid = $('#playerlist').isotope({
	  // options
	  itemSelector: '.playerBox',
	  sortAscending: false,
	  sortBy: 'val',
	  getSortData: {
		'val': '[data-val]',
		}
	});
	
	
	$('#playerlist').on( 'click', 'button', function() {
		var elem=$(this);
	 var filterValue = $( this ).attr('data-filter');
	 var originalfilter = $(this).attr('data-originalfilter');
	 if(filterValue==='*'){

		$('.filter').each(function(){
			$(this).html('show');
	 		$(this).attr('data-filter',$(this).attr('data-originalfilter'));
		});

	 	elem.html('show');
	 	elem.attr('data-filter',originalfilter);


	 }else{

		$('.filter').each(function(){
			$(this).html('show');
	 		$(this).attr('data-filter',$(this).attr('data-originalfilter'));
		});

	 	elem.html('hide');
	 	elem.attr('data-filter','*');
	 }
	 grid.isotope({ filter: filterValue });


	});

	$('#itemsby').on( 'click', 'button', function() {
	 var sortValue = $( this ).attr('data-sort');
	 grid.isotope({ sortBy: sortValue });
	});
	
	$('.knobtimer').each(function () { 

		var elm = $(this);
		var color = elm.attr("data-fgColor");  
		var perc = elm.attr("value");  
	 
		elm.knob({ 
			'min':0,
			'max':maxtimer,
			"readOnly":true,
			'dynamicDraw': true,
			"displayInput":false,
	                draw : function () { }
		});


		$({value: 0}).animate({ value: perc }, {
			duration: 500,
			easing: 'easeOutCubic',
			progress: function () {
				elm.val(Math.ceil(this.value)).trigger('change');
			}
		});

	});

	$('.knobitems').each(function () { 

		var elm = $(this);
		var color = elm.attr("data-fgColor");  
		var perc = elm.attr("value");  
	 
		elm.knob({ 
			'min':0,
			'max':maxitems,
			"readOnly":true,
			'dynamicDraw': true,
			"displayInput":false,
	                draw : function () { }
		});


		$({value: 0}).animate({ value: perc }, {
			duration: 500,
			easing: 'easeOutCubic',
			progress: function () {
				elm.val(Math.ceil(this.value)).trigger('change');
			}
		});

	});

	console.log('SteamID: '+userid);

	io.on('handshake', function(data){
		console.log('Connected.');
	});

	io.on('online', function(data){
		$('#online').text(data);
		console.log('Online: '+data);
	});

	io.on('steamstatus', function(data){
		//console.log('steamstatus: '+data);
		console.log('Received steam status.')
		$('#steamstatus').html(data);
                
	});
	/*
	io.on('cc', function(data){
		console.log('cc: '+data);
		$('#cc').html(data);
	});
	*/
	io.on('message', function(data){
		console.log('Received message.'+data.to+'=='+userid);
		if(userid===data.to){
                        notie.alert(1, data.msg, 3.5);
                        console.log(data.msg);
		}
	});

	io.on('adminmessage', function(data){
		console.log('Received message from the admin.');
                        notie.alert(1, data.msg, 6.5);
                        console.log(data.msg);
	});


	io.on('roundstart', function(data){
		console.log('Round started.');	$('#start-game-sound')[0].play();
		if(intervalrunning!==true){
			interval = setInterval(updatetimer, 1000); //game already running, start timer
			intervalrunning = true;
		}else{
			console.log('interval already set...');
		}
	
	});

	io.on('roundupdate', function(data){
		console.log('Received round update.');
	
		
		var data=JSON.parse(data);

		var newitems=data.newitems;
		var newitemscount=data.newitems.length;
		var elems = [];
		var itemsval=0;
		

		
/*
		for(var i=0;i<newitemscount;i++){
			itemsval=itemsval+newitems[i].cost;
			elems[i]=$('<div class="itemNew i'+newitems[i].userid+' i'+newitems[i].qualityclass+'" data-quality="i'+newitems[i].qualityclass+'"><img src="http://steamcommunity-a.akamaihd.net/economy/image/'+newitems[i].icon+'/105fx98f" alt="LOADING"/><span class="itemName">'+newitems[i].item+'</span><span class="itemprice">$<span class="sortcost">'+newitems[i].cost+'</span></span></div>');
			grid.isotope('insert',elems[i]);

		}
*/		
		for(var i=0;i<newitemscount;i++){
			itemsval=itemsval+newitems[i].cost;
			elems[i]=$('<div class="item i'+newitems[i].userid+' i'+newitems[i].qualityclass+'" data-quality="i'+newitems[i].qualityclass+'"><img src="http://steamcommunity-a.akamaihd.net/economy/image/'+newitems[i].icon+'/105fx98f" alt="LOADING"/><span class="iteminfo">'+newitems[i].item+'</span><span class="itemprice">$<span class="sortcost">'+newitems[i].cost+'</span></span></div>');
			grid.isotope('insert',elems[i]);	$('#new-item-sound')[0].play();

		}
		
		
		

	  	newitems[0].username=newitems[0].username;
	  	if($('#p'+newitems[0].userid).length){
	  		var formerdeposited=parseInt($('#deposit'+newitems[0].userid).text());
			
	  		var thisdeposited=newitemscount+formerdeposited;
			
				var newchance2=(newvalue/data.current_bank)*100;
				
			var formervalue=parseFloat($('#value'+newitems[0].userid).text().replace('$',''));
			
	  		var newitemsval=itemsval+formervalue;
				
			
			var template=$('<div class="playerBox" id="p'+newitems[0].userid+'" data-val="'+itemsval+'"><span class="playerName"><img src="'+newitems[0].avatar+'" alt=""/><a href="http://steamcommunity.com/profiles/'+newitems[0].userid+'/" target="_blank">'+htmlspecialchars(newitems[0].username)+'</a></span><span class="playerItems" id="deposit'+newitems[0].userid+'">'+thisdeposited+'</span><span class="playerTotal" id="value'+newitems[0].userid+'">$'+myround(newitemsval)+'</span><!--<span class="playerOdds"></span>--></div>');
	  		//playersgrid.isotope('remove',$('#p'+newitems[0].userid));
	  		$('#p'+newitems[0].userid).remove();
	  		console.log('Player already in-game, updating (remove + insert)...');

	  	}else{
	  		var template=$('<div class="playerBox" id="p'+newitems[0].userid+'" data-val="'+itemsval+'"><span class="playerName"><img src="'+newitems[0].avatar+'" alt=""/><a href="http://steamcommunity.com/profiles/'+newitems[0].userid+'/" target="_blank">'+htmlspecialchars(newitems[0].username)+'</a></span><span class="playerItems" id="deposit'+newitems[0].userid+'">'+newitemscount+'</span><span class="playerTotal" id="value'+newitems[0].userid+'">$'+myround(itemsval)+'</span><!--<span class="playerOdds"></span>--></div>');
	  		console.log('Player not in-game, inserting (insert)...');
	  		//$('.roulette').append('<img id="avatar'+newitems[0].userid+'" src="'+newitems[0].avatar+'"/>'+"\r\n");
	  	}
	  	
	  	$('#playerlist').prepend(template);
	  	
	  	playersgrid.isotope('insert',template);
	  	if(userid!=0){
		  	if(userid==newitems[0].userid){
		  		var newtotalitems=newitemscount + parseInt($('#myitems').text());
		  		$('#myitems').text(newtotalitems);

		  		var newvalue=itemsval+parseFloat($('#myvalue').text());
		  		$('#myvalue').text(myround(newvalue));

		  		var newchance=(newvalue/data.current_bank)*100;
		  		$('#mychance').text(myround(newchance));
		  	}else{
		  		if($('#value'+userid).length){
		  			var thisismyvalue=$('#myvalue').text();
		  			console.log(thisismyvalue+' / '+data.current_bank);
			  		var thenewchance=parseFloat( ( parseFloat( $('#myvalue').text() ) / data.current_bank ) * 100);
					console.log(thenewchance);
			  		$('#mychance').text(myround(thenewchance));
		  		}
		  	}
	  	}

		$('#playersnum').html(data.playersnum+' ');
		$('#gameid').html(data.current_game);
		$('#itemsinpot').html(data.itemsnum+'/50');
		itemsknob(data.itemsnum);
		$('#potworth').html('$'+myround(data.current_bank));
		$('#potworth2').html(myround(data.current_bank));
		$('title').html('$'+myround(data.current_bank)+' CSGOSNAFFY');
		$('#itemsnum').html(data.itemsnum);
		$.playSound('http://csgogrind.com/msg');

	});

	io.on('roundend', function(data){

		console.log('Round ended.');
	
		
		var data=JSON.parse(data);

		data.winnername=data.winnername;
		//var winnertemplate=$('<div id="thewinner" class="thewinner"><h1>WINNER</h1><img src="'+data.winneravatar+'" alt=""/> <b>'+htmlspecialchars(data.winnername)+'</b> won <b>$'+data.totalvalue+'</b><br/>winning ticket can be found at '+data.winnerpercent+'%<br/>round secret is '+data.winnersecret+'<br/></div>');
		var winnertemplate=$('<img src="'+data.winneravatar+'" alt="" /><a href="http://steamcommunity.com/profiles/'+data.winnerid+'/" target="_blank" class="userLink">'+htmlspecialchars(data.winnername)+'</a><p class="userWon">Won <b>$'+myround(data.totalvalue)+'</b> with a $'+myround(data.winnerdeposit)+' deposit</p><span><b>Winning ticket at</b>: '+data.winnerpercent+'%</span><span><b>Secret: </b>'+data.winnersecret+'</span><span><b>Hash: </b>'+data.winnerhash+'</span><a class="vertifyBTN" href="provablyfair.php?hash='+data.winnerhash+'&amp;secret='+data.winnersecret+'&amp;roundwinpercentage='+data.winnerpercent+'&amp;totaltickets='+myround(data.totalvalue)+'" target="_blank">Verify round</a>');

		clearInterval(interval);
		intervalrunning=false;
		timeleft=maxtimer;
		$('.hidemetheyrecoming').hide();
		
		$('.hidemetheyrecoming').html(winnertemplate);
		$(".roulette2").empty();
		
				$.ajax({
					type: "GET",
					url: "loadr.php",
					dataType: "html",
					success: function(msg){
								     $('.kjmhgd').show(500000000);
		      $(".kjmhgd").html(msg);
			  $('#start-roule-sound')[0].play();
			    $('#jackpotPlayers').animate({
        'marginTop' : "+=50px" //moves down
        });
		 $('#jackpotPlayers').animate({
        'marginTop' : "+=-50px" //moves down
        });
					
					}
				});
								$.ajax({
					type: "GET",
					url: "roulette.php",
					dataType: "html",
					success: function(msg){

					
					}
				});
  	setTimeout(function() {
		 $("#hjgfd").remove();
		  $('#jackpotPlayers').animate({
        'marginTop' : "+=-65px" //moves down
        });
		 $('#jackpotPlayers').animate({
        'marginTop' : "+=65px" //moves down
        });
		$('.hidemetheyrecoming').html(winnertemplate); 
	$('#winna').html('<div id="rekr" style="display:block"><img src="'+data.winneravatar+'" width="80px" height="80px" alt="" style="border-radius:50%; -moz-box-shadow: 0 0 5px green;-webkit-box-shadow: 0 0 5px green; box-shadow: 0px 0px 5px green; -webkit-animation: flipInY ease-in 1;-moz-animation:flipInY ease-in 1;animation:flipInY ease-in 1;-webkit-animation-duration:0.5s;-moz-animation-duration:0.5s;animation-duration:0.5s; position:relative; top:60px; left:33px;"><div class="centerInfo" style="left:-52px; margin-top:-75px;"><div id="realWinnerName" style="  overflow:hidden; white-space:nowrap;text-overflow:ellipsis; margin-bottom: 1px; margin-left: 66px;  top: -12px; position: relative;width: 800px;-webkit-animation: tada ease-in 1;-moz-animation:tada ease-in 1;animation:tada ease-in 1;-webkit-animation-duration:0.5s;-moz-animation-duration:0.5s;animation-duration:0.5s; ">'+ data.winnername+' Won the $<span id="roulleteworth">'+myround(data.totalvalue)+'</span> pot!    <i id="trophej" style=" left: 10; position: relative;-webkit-animation: flipInY ease-in 1; -moz-animation:flipInY ease-in 1;animation:flipInY ease-in 1;-webkit-animation-duration:0.5s;-moz-animation-duration:0.5s;animation-duration:0.5s;top: 7px;"class="fa-trophy"></i></div></div><div class="roulette2"> </div></div>');
					$('.hidemetheyrecoming').show();	
				
						if(userid===data.winnerid){
		if(userid===data.winnerid){
			
swal({   title: "Congratulations!",   text: "<center style='font-weight:bold; font-size:18px;'><span style='color:#c1c1c1;'>You've won: </span><span style='color:green; font-weight:bold;'>"+myround(data.totalvalue)+"$</span></center><br><span>Your winnings will be sent in the next 1-30 minutes, please be patient. </span><a href='../accept.php' target='_blank'><span style='color: green; text-decoration:underline;'>Accept</span></a><span style='color:#c1c1c1;'>  them here</span><br><center style='font-size:15px; font-weight:bold'><span>Secret: "+data.winnersecret+"</span></center>",   	html: true });
		}
		}	

	},13500);	
/*		$('#avatar'+data.winnerid).remove();
	  	$('.roulette').append('<img id="winner'+data.winnerid+'" src="'+data.winneravatar+'"/>');
	  	console.log($('.roulette').html());
	  	var stopat=$("#roulette img").length;
		console.log('/');*/


						
			$('#playerlist').empty();
		$('#hash').text(data.newhash);
setTimeout(function(){ $('#rekr').fadeOut(500, function() {
   $('#winna').empty();
}); }, 15500);
		var nextgame=parseInt($('#gameid').text())+1;
		$('#gameid').html(nextgame);
		$('#itemsinpot').html(0+'/50');
		itemsknob(0);
		timerknob(maxtimer);
		$('div#timeleft').text(maxtimer);
		$('#potworth').html('$0');
		$('#potworth2').html('0');
		$('#itemsnum').html('0');
		$('#myitems').html('0');
		$('#myvalue').html('0');
		$('#mychance').html('0');
        $('#inventoryitems').empty()
		$('#playersnum').html('0 ');
		$('title').html('CSGOSNAFFY');
		$('#playerlist').css('height','auto');
		$('#playerlist').css('min-height','200px');

/*	
		console.log('starting..');
	  	$('div.roulette').roulette('start');
*/

	});



 });
function myround(inpvar){
	inpvar=parseFloat(inpvar);
	var resultvar;
	if(inpvar>99.99){
		resultvar=Math.round(inpvar);
	}
	else if(inpvar>9.99 && inpvar<99.99){
		resultvar=inpvar.toFixed(1);
	}
	else{
		resultvar=inpvar.toFixed(2);
	}

	return resultvar;
}
function htmlspecialchars(str) {
 if (typeof(str) == "string") {
  str = str.replace(/&/g, "&amp;"); /* must do &amp; first */
  str = str.replace(/"/g, "&quot;");
  str = str.replace(/'/g, "&#039;");
  str = str.replace(/</g, "&lt;");
  str = str.replace(/>/g, "&gt;");
  }
 return str;
 }


function itemsknob(value){
	
	if(value>maxitems){
		console.log('itemsknob(): value is '+value+' (>'+maxitems+'); setting value '+maxitems);
		value=maxitems;
	}
	if(value<0){
		console.log('itemsknob(): value is '+value+' (<0); setting value 0');
		value=0;
	}

	var elm = $('.knobitems');
	var perc = elm.attr("value");  

	elm.animate({ value: value }, {
		duration: 500,
		easing: 'easeOutCubic',
		progress: function () {
			elm.val(Math.ceil(this.value)).trigger('change');
		}
	});

}

function timerknob(value){

	var elmtime = $('.knobtimer');

	elmtime.animate({ value: value }, {
		duration: 0,
		easing: '',
		progress: function () {
			elmtime.val(Math.ceil(this.value)).trigger('change');
			if(timeleft>-1){
				$('#timeleft').text(value);
			}
		}
	});



	//console.log('timerknob() called. value: '+value);


}

function updatetimer(){
	var gettimeleft2=parseInt($('div#timeleft').text());
	//console.log('timeleft: '+gettimeleft2);

	timeleft=gettimeleft2-1;
	timerknob(timeleft);

	//console.log('timeleft2: '+timeleft);
}

/*
$(document).ready(function(){
	interval = setInterval(updatetimer, 1000);
});
*/