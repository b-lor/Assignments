"use strict";

let hoursWorked = prompt("Hours");
let payRate = prompt("rate");
let standardWorkWeekHours = 40;
let totalpay; //need to display here so you can display in all brackets

if(hoursWorked > standardWorkWeekHours) {
    let regularPay = standardWorkWeekHours * payRate;
    let overtimeHours = hoursWorked - standardWorkWeekHours;
    let overtimePayRateMultiplier = 1.5;
    let overtimePayRate = payRate * overtimePayRateMultiplier;
    let overtimePay = overtimeHours * overtimePayRate;
    totalpay = regularPay + overtimePay

} 

else {
    totalpay = hoursWorked * payRate

}

console.log(totalpay);