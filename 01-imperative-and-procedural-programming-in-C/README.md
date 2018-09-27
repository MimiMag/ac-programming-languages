# Imperative and procedural programming in C

## Content

* Intro - Programming in C
* Kata - Demo

## Intro - Programming in C
* C = low level programming langue
    * It is very close to CPU instructions
    * Also called, close to the metal
    * One lower level is Assembly, where you use CPU instructions directly

## Kata/Demo
### Assignment:
 * Convert hexadecimals into bytes
 * Your program should take two characters as input (like 'A', and 'B') and should transform it into a numeral value.

### Intro
#### Number systems
![number systems](http://www.electronicsengineering.nbcafe.in/wp-content/uploads/2014/09/number-systems.png)

There are ways to represent numbers:
  * Decimals is 10 based (0 ... 9)
  * Hexadecimals are 16 digit based (0 ... 9, A, B, C, D, E, F)
  * Binary base 2 (0, 1)

The hexadecimal value 'F' can be represented with the decimal value 15. The decimal value 15 can be represented represented as the binary value '1111'

>  🎓 Learn more about number systems at [Khan Academy](https://www.khanacademy.org/math/algebra-home/alg-intro-to-algebra/algebra-alternate-number-bases/v/number-systems-introduction) or [this article by Eugene Brennnan](https://owlcation.com/stem/How-to-Convert-Hex-to-Binary-and-Binary-to-Hexadecimal)

A hexadecimal could just be a shorthand for 4 bits. Let's see how that works.

A byte is some binary data that is 8 bits long:

|1|2|4|8|16|32|64|128|
|---|---|---|---|---|---|---|---|
||||||||
(2<sup>0</sup>)|(2<sup>1</sup>)|(2<sup>2</sup>)|(2<sup>3</sup>)|(2<sup>4</sup>)|(2<sup>5</sup>)|(2<sup>6</sup>)|(2<sup>7</sup>)|

With one byte, you could represent all decimal values up to 256.

When you add the numbers of the first four bits, you get 15. This is exactly the number of bits you can represent with a hexadecimal. You can represent four bits with one hexadecimal.

> 🎓 4 bits are also called a `nibble`

You need to hexadecimals to return one byte.

#### Operators

* `|` - or operator: 
  * it takes to numbers, to binary values and 'ors'  them:
    |A|B|R|
    |---|---|---|
    |0|0|0|
    |0 |1|1|
    |1|0|1|
    |1|1|1|

  * In this way, you could compare two numbers:
    input1 | 21 | 1 |0|1|0|1|
    |---|---|---|---|---|---|---|
    |input2|14|0|1|1|1|0|
    outcome with or|15| 1|1|1|1|1|

* `<<` - and operator (also called the `bitshift`)
  * multiply with `<<` operators


### Demo
* Not available here, so go and try, or join an advanced class next time 😉. Make sure to use TDD to fix this assignment!
![TDD mantra](http://lewandowski.io/images/tdd_flow.gif)


