# Scrabble


#### _Scrabble web app, 2.9.17_

#### By _**Katy Daviscourt and Caitlin Hines**_

## Description

_Use nancy, c# and razor to make an app that tells you the scrabble score of any inputted word._

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Support and contact details

_For questions contact Katy at katy.daviscourt@gmail.com_

## Technologies Used

_C#, Razor, Nancy_

### License

*Under MIT License*

Copyright (c) 2017 **_Katy Daviscourt and Caitlin Hines_**

## Specifications

* _Step1: the program returns the user's input as an output._
  * _Input: hello_
  * _Output: hello_
* _Step2: If the user inputs a word with characters with a value of 1, the program will return the correct value of that word._
  * _Input: eat_
  * _Output: 3_
* _Step3: If the user inputs a word with characters with a value of 2 or 1, the program will return the correct value of that word._
    * _Input: dot_
    * _Output: 4_
* _Step4: If the user inputs a word with characters with a value of 3, 2 or 1, the program will return the correct value of that word._
    * _Input: peed_
    * _Output: 7_
* _Step5: If the user inputs a word with characters with a value of 4, 3, 2 or 1, the program will return the correct value of that word._
    * _Input: width_
    * _Output: 12_
* _Step6: If the user inputs a word with characters with a value of 5, 4, 3, 2 or 1, the program will return the correct value of that word._
    * _Input: kite_
    * _Output: 8_
* _Step7: If the user inputs a word with characters with a value of 8, 5, 4, 3, 2 or 1, the program will return the correct value of that word._
    * _Input: job_
    * _Output: 12_
* _Step8: If the user inputs a word with characters with a value of 10, 8, 5, 4, 3, 2 or 1, the program will return the correct value of that word._
    * _Input: quiz_
    * _Output: 22_
* _Step9: The program outputs the write value regardless of upper/lower case._
    * _Input: Quiz_
    * _Output: 22_
