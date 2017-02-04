<!DOCTYPE html>
<html>
<?php require_once 'steamauth/userInfo.php'; ?>
  <head>
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link type="text/css" rel="stylesheet" href="materialize/css/materialize.min.css"  media="screen,projection"/>
    <link href="/css/zmd.hierarchical-display.min.css" rel="stylesheet">
    <link rel="icon" href="/favicon.ico?" type="image/x-icon">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <style>
    .ctxMenu {
      position: absolute;
      width: 5%;
      background-color: white;
      color:black;
      border: 2px solid lightgrey;
      border-radius: 5px;
    }
    .ctxMenu li:hover{
      background-color: lightblue;
    }
    #chatToggle {
      position: absolute;
      display: block;
      margin-top: 15%;
      left: 24.125%;
      transition: none;
      transition: box-shadow 300ms ease;
    }
    #chat-col {
      position:absolute;
      width:25%;
    }
    #chat-toggle-icon{
      font-size: 40px;
      transform: rotate(-90deg);
      transition: transform 500ms ease-out;
    }
    .chat {
      overflow: auto;
      border: 1px solid lightgrey;
      background-color:white;
      padding: 0.3em;
    }
    .chat-image {
      border: 2px solid white;
      border-radius: 8px;
      vertical-align: middle;
    }
    .chat-link:hover {
      text-decoration: underline;
    }
    </style>
  </head>
  <body class="grey lighten-1">
  <header>
    </header>
    <main>
    <div class="container">
        <div id="chat-header" class="chat" style="border-radius: 0.5em 0.5em 0 0;border-bottom: none;">
          <span>Чат</span>
          <span style="float: right;">Онлайн: <span id="online">0</span><input type="checkbox" id="chatpause" />&nbsp;&nbsp;&nbsp;&nbsp;<label for="chatpause">Пауза</label></span>
        </div>
        <div class="chat" id="chat">
          <?php
            session_start();
            if(!isset($_SESSION['loggedin']) || !$_SESSION['loggedin']) {
              echo '<div><i>Login through steam to connect.</i></div>';
            }
          ?>
        </div>
        <div id="chat-input" class="chat" style="border-top: none; padding-top: none;">
          <form id="chatForm" autocomplete="off">
            <input id="chatMessage" type="text" placeholder="Chat Message" style="margin:0;">
          </form>
        </div>
      </div>
    </main>
    <span id="vars" style="display: none;">
      <?php
        $lin = "false";
        if(isset($_SESSION['loggedin']) && $_SESSION['loggedin']) {
          $lin = "true";
        }
        echo "<phpvar id='loggedin'>".$lin."</phpvar>";
        echo "<phpvar id='avatar'>".$_SESSION['avatar']."</phpvar>";
        echo "<phpvar id='steamid'>"$_SESSION['steamid']"</phpvar>";
        echo "<phpvar id='name'>".$_SESSION['name']."</phpvar>";
        echo "<phpvar id='signupdate'>".$_SESSION['signup_date']."</phpvar>";
        echo "<phpvar id='logintime'>".$_SESSION['login_time']."</phpvar>";
        echo "<phpvar id='salt'>".$_SESSION['salt']."</phpvar>";
        include 'referrers.php'; echo "<phpvar id='referrers'>".json_encode($referrers)."</phpvar>";
                          session_write_close();
            $mod = "false";
            if(isset($_SESSION['mod']) && $_SESSION['mod']) {
              $mod = "true";
            }

      ?>
    </span>
    <span id="escape"></span>
    <script type="text/javascript" src="http://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="/materialize/js/materialize.min.js"></script>
    <script type="text/javascript" src="/js/sha256.js"></script>
    <script>
    var loggedinn = $("#loggedin").text() == 'true';
    var avatar = $("#avatar").html();
    var steamid = $("#steamid").html();
    var name = $("#name").html();
    var signupdate = $("#signupdate").html();
    var logintime = $("#logintime").html();
    var salt = $("#salt").html();
    var streamers = $("#referrers").html();
    if(loggedinn) {
      function escapeStr(str) {
        $("#escape").text(str);
        var escaped = $("#escape").html();
        $("#escape").html("");
        return escaped;
      }
            var mysocket = new WebSocket("ws://213.159.215.102:8080/", "roulette");

      mysocket.onopen = function(event) {
        console.log("Connected!");
        $("#chat").html($("#chat").html() + "\n<div class=\"green-text\"><i>Connected!</i></div>");
        $("#chat").html($("#chat").html() + "\n<div class=\"blue-text\"><i><b>Rules: 1. No Begging. 2. English ONLY 3. No code sharing. 4. No advertising. 5. No harassment. 6. You agree that WheelOfSkinz.com is not liable for any coins lost due to network error. (Do not ask for your coins back)<b></i></div>");
        $("#chat").html($("#chat").html() + "\n<div class=\"green-text\"><i>Generating authentication token.</i></div>");
        var token = SHA256.hash(steamid+"-"+signupdate+"-"+logintime+"-"+salt);
        var authPacket = JSON.stringify({type:"auth", steamid:steamid, token: token, name:name, avatar:avatar});
        mysocket.send(authPacket);
      }
      mysocket.onmessage = function(event) {
        var data = JSON.parse(event.data);
        if(data.type=="usercount") {
          $("#online").text(data.count)
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

            var streamer = streamers.includes(data.steamid);
                if(data.owner) {
                  data.player = "<span class=\"red-text\">[OWNER] "+data.player+"</span>";
                } else if(data.steamid == "STEAMID?") {
                  data.player = "<span class=\"pink-text text-lighten-1\">[SLUTTY ADMIN] "+data.player+"</span>";
                } else if(data.steamid == "76561198201296986") {
                  data.player = "<span class=\"black-text\">[LOSER] "+data.player+"</span>";
                } else if(data.steamid == "76561198170844598") {
                  data.player = "<span class=\"purple-text text-darken-3\">[LUCKY BITCH] "+data.player+"</span>";
                } else if(data.steamid == "76561198232982272") {
                  data.player = "<span class=\"blue-text text-darken-3\">[ADMIN] "+data.player+"</span>";
                } else if(data.steamid == "76561198252982272") {
                  data.player = "<span class=\"deep-purple-text\">[\"Safe\" better] "+data.player+"</span>";
                } else if(data.steamid == "76561198187894321") {
                  data.player = "<span class=\"amber-text text-darken-1\">[Veteran] "+data.player+"</span>";
                } else if(data.mod) {
                  data.player = "<span class=\"lightblue-text\">[MOD] "+data.player+"</span>";
                } else if(streamer) {
                  data.player = "<span class=\"teal-text text-accent-3\">[STREAMER] "+data.player+"</span>";
                } else {
                  data.player = "<span class=\"black-text\">"+data.player+"</span>";
                }
              $("#chat").html($("#chat").html() + '\n<div><a href="javascript:void(0)" class="chatimglnk" steamid="'+data.steamid+'"><img src="'+data.avatarurl+'" class="chat-image"></a> <a class="chat-link" href="http://steamcommunity.com/profiles/'+data.steamid+'"><b>'+data.player + '</b></a>: ' + escapeStr(data.message) + '</div>');
               
            break;
            default: break;
          }
          $(".chatimglnk").click(function(e) {
            $(".ctxMenu").remove();
              clearTimeout(ctxMenuTimeout);
              var me = $(this);
              $("body").append(<?php
                echo "'";
                echo '<div class="ctxMenu" style="left:\'+e.pageX+\'px; top:\'+e.pageY+\'px;">';
                echo '<ul>';
                echo '<a href="javascript:void(0)" onclick="sendcash(\\\'\'+me.attr("steamid")+\'\\\')"><li>Send Coins</li></a>';
                if(isset($_SESSION['loggedin']) && $_SESSION['mod'] == 1) {
                  echo '<a href="javascript:void(0)" onclick="mute(\\\'\'+me.attr("steamid")+\'\\\')"><li>Mute Player</li></a>';
                  echo '<a href="javascript:void(0)" onclick="unmute(\\\'\'+me.attr("steamid")+\'\\\')"><li>Unute Player</li></a>';
                }
                echo '</ul>';
                echo '</div>';
                echo "'";
              ?>);
              ctxMenuTimeout = setTimeout(function() {
              $(".ctxMenu").remove();
            }, 2000);
          });
          if(!$("#chatpause").is(":checked")){
            $("#chat").stop();
            $("#chat").animate({ scrollTop: $("#chat")[0].scrollHeight - $("#chat").height() }, 1000 * 2^30, "easeOutCirc", function() {
              while($("#chat").find("div").length > 50) {
                $("#chat").find("div")[0].remove();
              }
            });
          } else {
            while($("#chat").find("div").length > 50) {
              $("#chat").find("div")[0].remove();
            }
          }
        }
      }
      $("#chatForm").on("submit", function() {
        var msg = $("#chatMessage").val();
        if(msg && loggedinn) {
          mysocket.send(JSON.stringify({
            type:"chat",
            message:msg
          }));
        }
        $("#chatMessage").val("");
        return false;
      });
    }
    function tick() {
      $("#chat").height($(window).height() - 102+"px")
      requestAnimationFrame(tick);
    }
    tick();
    </script>
  </body>
</html>



