var io = io.connect('http://213.159.215.102:3000');
var interval;
var intervalrunning=false;
var userid2;


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
		    dataType: "html",
		    url: "roulette.php?"+Math.random(),
		    success: function(msg){
		     $('#roulette').show();
		      $(".roulette2").html(msg);
			console.log('Showing roulette...');
		    }
		  });
});

$(document).ready(function(){

	        	var height = Math.max($("#chat").height(), $("#sidebar").height(), $("#content").height());
		        $("#sidebar").height(height);
		        $("#content").height(height);


	var gettimeleft=parseInt($('div#timeleft').text());
	//console.log(gettimeleft);
	var timeleft=parseInt(gettimeleft);
	if(timeleft<maxtimer){
		if(intervalrunning!==true){
			interval = setInterval(updatetimer, 1000); //game already running, start timer
			intervalrunning = true;
		}else{
			console.log('interval already set...');
		}
	}

	var userid=$('#userid').text();

	var grid = $('.grid').isotope({
	  // options
	  itemSelector: '.item',
	  sortAscending: false,
	  sortBy: 'cost',
	  getSortData: {
		'cost': '.sortcost',
		'quality': '[data-quality]',
		},
	  masonry: {
	    columnWidth: 132
	  }
	});

	var playersgrid = $('#playerlist').isotope({
	  // options
	  itemSelector: '.playerrow',
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

	io.on('cc', function(data){
		console.log('cc: '+data);
		$('#cc').html(data);
	});

	io.on('message', function(data){
		console.log('Received message.'+data.to+'=='+userid);
		if(userid===data.to){
			alert(data.msg);
		}
	});

	io.on('roundstart', function(data){
		console.log('Round started.');
		if(intervalrunning!==true){
			interval = setInterval(updatetimer, 1000); //game already running, start timer
			intervalrunning = true;
		}else{
			console.log('interval already set...');
		}
	});

	io.on('roundupdate', function(data){
		console.log('Received round update.');
		//console.log('data received: '+data);
		
		var data=JSON.parse(data);

		var newitems=data.newitems;
		var newitemscount=data.newitems.length;
		var elems = [];
		var itemsval=0;


		for(var i=0;i<newitemscount;i++){
			itemsval=itemsval+newitems[i].cost;
			elems[i]=$('<div class="item i'+newitems[i].userid+' i'+newitems[i].qualityclass+'" data-quality="i'+newitems[i].qualityclass+'"><img src="http://steamcommunity-a.akamaihd.net/economy/image/'+newitems[i].icon+'/105fx98f" alt="LOADING"/><span class="itemprice">$<span class="sortcost">'+newitems[i].cost+'</span></span><span class="iteminfo">'+newitems[i].item+'</span></div>');
			grid.isotope('insert',elems[i]);

		}

	  	newitems[0].username=antispam(newitems[0].username);
	  	if($('#p'+newitems[0].userid).length){
	  		var formerdeposited=parseInt($('#deposit'+newitems[0].userid).text());
	  		var thisdeposited=newitemscount+formerdeposited;
			var formervalue=parseFloat($('#value'+newitems[0].userid).text().replace('$',''));
	  		var newitemsval=itemsval+formervalue;
			var template=$('<div class="playerrow" id="p'+newitems[0].userid+'" data-val="'+itemsval+'"><div class="playeravatar"><img src="'+newitems[0].avatar+'" alt=""/></div><div class="playerinfo"><span class="playername"><a href="http://steamcommunity.com/profiles/'+newitems[0].userid+'/" target="_blank">'+htmlspecialchars(newitems[0].username)+'</a>'+cc(newitems[0].userid)+'</span><br/><span>deposited <span id="deposit'+newitems[0].userid+'" class="normalspan">'+thisdeposited+'</span> items (<button class="filter link" data-filter=".i'+newitems[0].userid+'" data-originalfilter=".i'+newitems[0].userid+'" title="items deposited by '+htmlspecialchars(newitems[0].username)+'">show</button>) <b id="value'+newitems[0].userid+'">$'+myround(newitemsval)+'</b></span><br/></div></div>');
	  		//playersgrid.isotope('remove',$('#p'+newitems[0].userid));
	  		$('#p'+newitems[0].userid).remove();
	  		//console.log('Player already in-game, updating (remove + insert)...');

	  	}else{
	  		var template=$('<div class="playerrow" id="p'+newitems[0].userid+'" data-val="'+itemsval+'"><div class="playeravatar"><img src="'+newitems[0].avatar+'" alt=""/></div><div class="playerinfo"><span class="playername"><a href="http://steamcommunity.com/profiles/'+newitems[0].userid+'/" target="_blank">'+htmlspecialchars(newitems[0].username)+'</a>'+cc(newitems[0].userid)+'</span><br/><span>deposited <span id="deposit'+newitems[0].userid+'" class="normalspan">'+newitemscount+'</span> items (<button class="filter link" data-filter=".i'+newitems[0].userid+'" data-originalfilter=".i'+newitems[0].userid+'" title="items deposited by '+htmlspecialchars(newitems[0].username)+'">show</button>) <b id="value'+newitems[0].userid+'">$'+myround(itemsval)+'</b></span><br/></div></div>');
	  		//console.log('Player not in-game, inserting (insert)...');
	  		//$('.roulette').append('<img id="avatar'+newitems[0].userid+'" src="'+newitems[0].avatar+'"/>'+"\r\n");
	  	}
	  	
	  	//$('#playerlist').prepend(template);
	  	
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
		$('title').html('$'+myround(data.current_bank)+' YoloSkins.com');
		$('#itemsnum').html(data.itemsnum);


	});

	io.on('roundend', function(data){

		console.log('Round ended.');
		//console.log('data received: '+data);
		
		var data=JSON.parse(data);

		data.winnername=antispam(data.winnername);
		//var winnertemplate=$('<div id="thewinner" class="thewinner"><h1>WINNER</h1><img src="'+data.winneravatar+'" alt=""/> <b>'+htmlspecialchars(data.winnername)+'</b> won <b>$'+data.totalvalue+'</b><br/>winning ticket can be found at '+data.winnerpercent+'%<br/>round secret is '+data.winnersecret+'<br/></div>');
		var winnertemplate=$('<div class="playeravatar"><img src="'+data.winneravatar+'" alt=""/></div><div class="playerinfo"><span class="playername"><a href="http://steamcommunity.com/profiles/'+data.winnerid+'/" target="_blank">'+htmlspecialchars(data.winnername)+'</a>'+cc(data.winnerid)+'</span><br/><span>Won with a $'+myround(data.winnerdeposit)+' deposit</span><b>$'+myround(data.totalvalue)+'</b></span><br/></div><div style="padding-left:5px;display:inline-block;font-size:85%;color:lightgray">winning ticket at: '+data.winnerpercent+'%<br/>secret: '+data.winnersecret+'<br/>hash: '+data.winnerhash+'<br/><a href="provablyfair.php?hash='+data.winnerhash+'&amp;secret='+data.winnersecret+'&amp;roundwinpercentage='+data.winnerpercent+'&amp;totaltickets='+myround(data.totalvalue)+'" target="_blank">Verify round</a></div>');

		clearInterval(interval);
		intervalrunning=false;
		timeleft=maxtimer;
		$('.hidemetheyrecoming').hide();
		$('.hidemetheyrecoming').html(winnertemplate);
		$(".roulette2").empty();
		
		    $.ajax({
		    type: "GET",
		    dataType: "html",
		    url: "roulette.php",
		    success: function(msg){
		      $(".roulette2").html(msg);
			console.log('Showing roulette...');
		    }
		  });

/*		$('#avatar'+data.winnerid).remove();
	  	$('.roulette').append('<img id="winner'+data.winnerid+'" src="'+data.winneravatar+'"/>');
	  	console.log($('.roulette').html());
	  	var stopat=$("#roulette img").length;
		console.log('/');*/

	  	$('#roulleteworth').html(myround(data.totalvalue));

	  	$('#winnername').hide();
	  	$('#winnername').html(htmlspecialchars(data.winnername));
	  	$('#roulette').show();


		$('#playerlist').empty();
		$('#hash').text(data.newhash);

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
		$('#inventoryitems').empty();
		$('#playersnum').html('0 ');
		$('title').html('YoloSkins.com');
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
function antispam(nick) {
	var result = nick.replace(/\s+/, "").match(/(([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?)/i);
	if(result && !result[1].match(/YoloSkins?\.com/i)){
		//return "***";
		return nick.replace(/([\da-z\.-]+)\.([a-z\.]{2,4})([\/\w \.-]*)*\/?/i, "✪");
	}
	return nick;
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