"use strict"; 

function takeHome(amount)
{
     var rate, hours, regpay, overtime, pay ;
     hours = document.getElementById("hours").value;
     rate = document.getElementById("rate").value;
     
     if (hours>=40)
     {
         regpay = (rate*40)
         overtime = ((rate * 1.5) * (hours - 40))
         pay = (regpay + overtime)
     }
     else
     {
     pay = rate*hours;
     }
     return document.getElementById("amount").innerHTML=pay;
}

function clearly()
{
    var clear = document.getElementById("hours").value = ""; 
    var clear = document.getElementById("rate").value = ""; 
    document.getElementById("amount").innerHTML="";
    return clear;  
}