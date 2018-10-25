"use strict"; 

window.onload=function()
{
     var rate, hours, regpay, overtime, pay ;
     hours = window.prompt('How many hours have you worked ?');
     rate = window.prompt('What is your rate of pay ?');
     
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


console.log("Your total pay is $" + pay);

}