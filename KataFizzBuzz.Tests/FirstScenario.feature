Feature: Convert a number to a specify word
In order to avoid silly mistakes
As a collegean student
I want to convert a number to a string for practising multiply

Scenario Outline: Convert a number multipleofthree to Fizz
When I ask to convert a <numberMultipleOfThree>
Then The result of the conversion should be a <word>
Examples: 
| numberMultipleOfThree | word           |
| 3                     | Fizz           |
| 6                     | Fizz           |
| 9                     | Fizz           |
|12                     | Fizz           |

Scenario Outline: Convert a number multipleoffive to Buzz
When I ask to convert a <numberMultipleOfFive>
Then The result of the conversion should be a <word>
Examples:
|numberMultipleOfFive   | word           |
|5                      | Buzz           |
|10                     | Buzz           |
|20                     | Buzz           |

Scenario Outline: Convert a number multipleofthreeandfive to FizzBuzz
When I ask to convert a <numberMultipleOfThreeAndFive>
Then The result of the conversion should be a <word>
Examples: 
|numberMultipleOfThreeAndFive  | word           |
|15                            | FizzBuzz       |
|30                            | FizzBuzz       |
|45                            | FizzBuzz       |

Scenario Outline: Convert a number non multipleofthreeandfive to itself
When I ask to convert a <numberNonMultiple>
Then The result of the conversion should be a <word>
Examples: 
| numberNonMultiple  | word |
| 1                  | 1    |
| 2                  | 2    |
| 4                  | 4    |
| 7                  | 7    |

Scenario: Prohibit zero
When I ask to convert a 0
Then An Error indicates "zero can't be converted"


Scenario Outline: Prohibit numbers greater than 100
When I ask to convert a <number>
Then An Error indicates "number cannot be greater than 100"
Examples: 
|number|
|101   |
|110   |
|135   |
|145   |
|210   |