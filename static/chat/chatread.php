<?php 
include 'chatfunctions.php';
include 'adminlist.php';
          $f_arr = file( "../ajax/chat.txt" );
          foreach($f_arr as $value)
          {
          echo $value;
          }
        ?>    