<!DOCTYPE html>
<html lang="en">
<head> 
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="description" content="Sample PHP Website" />
    <meta name="keywords" content="Web,deployment" /> 
    <meta name="author" content="Tran Minh Hanh - 103792517" /> 
    <title>Deployment Portfolio Task 3</title>
</head> 

<body>
    <h1>Is This Number Odd Or Even?</h1> 
    <?php
    if(isset($_GET["variable"])) {
        //$value = 4;
        $value = $_GET["variable"];
        if(is_numeric($value)){
            if(round($value) % 2 == 0){
            $odev = "even";
        } else {
            $odev = "odd";
        }
        echo "The variable $value contains an $odev number.";
        } else {
            echo "This variable $value is not a number.";
        }
    } else {
        echo "Not a number! Please return to <a href='index.php'>index</a>.";
    }
    ?>
</body>
</html>