<?php

    $function = $_POST['function'];
    
    $log = array();
    
    switch($function) {
    
    	 case('getState'):
        	 if(file_exists('chat.db')){
               $lines = file('chat.db');
        	 }
             $log['state'] = count($lines); 
        	 break;	
    	
    	 case('update'):
        	$state = $_POST['state'];
        	if(file_exists('chat.db')){
        	   $lines = file('chat.db');
        	 }
        	 $count =  count($lines);
        	 if($state == $count){
        		 $log['state'] = $state;
        		 $log['text'] = false;
        		 
        		 }
        		 else{
        			 $text= array();
        			 $log['state'] = $state + count($lines) - $state;
        			 foreach ($lines as $line_num => $line)
                       {
        				   if($line_num >= $state){
                         $text[] =  $line = str_replace("\n", "", $line);
        				   }
         
                        }
        			 $log['text'] = $text; 
        		 }
        	  
             break;
    	 
			case('send'):
				$nickname = $_POST['nickname'];
				$ava = $_POST['ava'];
				$message = htmlentities(strip_tags($_POST['message']));
				if(($message) != "\n"){
					fwrite(fopen('chat.db', 'a'), "<img src='".$ava."' height='50' width='50'></img><p style='float: right;width: 210px;overflow-wrap: break-word;padding: 3px;padding-left: 13px;margin: 0px;'><span>".$nickname."</span><br><span style='display: block;margin-top: 5px;'>".$message = str_replace("\n", " ", $message)."</span></p> \n"); 
				}
				break;
    	
    }
    
    echo json_encode($log);

?>