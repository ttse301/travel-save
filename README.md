UNSW Travel Save
================
Written by Elizabeth Sternhell, Theodora Tse and Wen Di Lim

## Disclaimer
1. All prices are currently concession only. 
2. Values and prices are accurate as per obtained on 12th October 2015.
3. Periodic updates may be pushed depending on popular demand.
4. Please report any bugs to wendilim@cse.unsw.edu.au. No guarantees on when we will fix them.

## Overview
UNSW Travel Save is a simple interface for calulating daily travel expenditure to UNSW for concession tickets, up to a week. It returns a few different ticket options and the prices associated with them.

Price calculation is detailed below. Understand that this service is for working out exactly how much money you will spend based on different options, but may not necessarily be the total cost of expenditure.

## Usage instructions
The site is live and running at http://ttse301.github.io

### Travel details
* If your primary mode of travel is by train, simply enter your origin train station and the number of days you are going to travel per week.
* If your primary mode of travel is by bus, add a bus section and select the appropriate ticket to uni.
* If your travel by bus AND by train, add the appropriate bus section and your origin train station.

### Understanding travel results
* All prices are return trip prices.
* The calculation of prices for train single and travel 10s goes like this: (train ticket price * number of days) +  (travel ten / number of travel days). 

## Developing instructions
Branch from the master and create a pull request.