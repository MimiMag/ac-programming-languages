# Imperative and procedural programming in C

## Content

* Intro - Programming in C
* Kata - Demo
* Using C - Intro and Tutorial

## Intro - Programming in C
* C = low level programming language
    * It is very close to CPU instructions
    * Also called, close to the metal
    * One lower level is Assembly, where you use CPU instructions directly
* C is a compiled language - which means that in order to run it, the compiler (for example, GCC or Visual Studio) must take the code that we wrote, process it, and then create an executable file. This file can then be executed, and will do what we intended for the program to do.

## Kata/Demo
### Assignment:
 * Convert hexadecimals into bytes
 * Your program should take two characters as input (like 'A', and 'B') and should transform it into a numeral value.

### Intro
#### Number systems
![number systems](http://www.electronicsengineering.nbcafe.in/wp-content/uploads/2014/09/number-systems.png)

There are several ways to represent numbers:
  * Decimals is 10 based (0 ... 9)
  * Hexadecimals are 16 digit based (0 ... 9, A, B, C, D, E, F)
  * Binary base 2 (0, 1)

The hexadecimal value 'F' can be represented with the decimal value 15. The decimal value 15 can be represented represented as the binary value '1111'

>  🎓 Learn more about number systems at [Khan Academy](https://www.khanacademy.org/math/algebra-home/alg-intro-to-algebra/algebra-alternate-number-bases/v/number-systems-introduction) or [this article by Eugene Brennnan](https://owlcation.com/stem/How-to-Convert-Hex-to-Binary-and-Binary-to-Hexadecimal)

Two hexidecimal values are often used to represent a byte of binary data. Let see how that works:

1. A byte is some binary data that is 8 bits long:

  |1|2|4|8|16|32|64|128|
  |---|---|---|---|---|---|---|---|
  ||||||||
  (2<sup>0</sup>)|(2<sup>1</sup>)|(2<sup>2</sup>)|(2<sup>3</sup>)|(2<sup>4</sup>)|(2<sup>5</sup>)|(2<sup>6</sup>)|(2<sup>7</sup>)|

1. With one byte, you could represent all decimal values up to 256.
1. When you add the numbers of the first four bits, you get 15, which means you can represent all decimal values up to 15. This is exactly the number of bits you can represent with a hexadecimal.  So you can represent four bits with one hexadecimal.
1. Which also means that in order to represent eight bits, you need hexadecimal values.

> 🎓 4 bits are also called a `nibble`

#### Operators you are allowed to use.

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

* `<<` - and bitwise operator (also called the `bit-shift`)
  * multiply with `<<` operators

> 🎓 Checkout all bitwise operators! For example in JavaScript (see [w3-schoos]())
> ![](https://cd.sseu.re/JavaScript_Bitwise_2018-09-27_11-09-33.png)


### Demo
* Not available here, so go and try, or join an advanced class next time 😉. Make sure to use TDD to fix this assignment!
![TDD mantra](http://lewandowski.io/images/tdd_flow.gif)

## Using C
### What C is good at:
* Cross-platform programming.
* Embedded and small-device programming.
* Operating system or kernel programming, or related areas such as writing device drivers.
* Other “system” areas such as database engines and kernels, networking code, etc.
* Other code that needs to be very high-performance, particularly if it has a “state machine” element where you really want to know what the code is doing at all times.

### Differences between C and Javascript:
* JavaScript is a dynamic language!
* Variables are not strongly-typed
* No native support for namespaces and classes (until ES6)
* Only 2 levels of variable scope (until ES6)
* Equality comparisons can be tricky
* Functions are objects by default
* [see this article for more info](https://www.interfacett.com/blogs/javascript-for-c-developers-difference-in-dynamic-syntax-and-c/)

## Tutorial

> 🎓 See [learn-c.org](https://www.learn-c.org/)

* Every C program uses libraries, which give the ability to execute necessary functions. For example, the most basic function called `printf`, which prints to the screen, is defined in the `stdio.h` header file.

* The second part of the code is the actual code which we are going to write. The first code which will run will always reside in the `main` function.

* The `int` keyword indicates that the function main will return an integer - a simple number. The number which will be returned by the function indicates whether the program that we wrote worked correctly. If we want to say that our code was run successfully, we will return the number 0. A number greater than 0 will mean that the program that we wrote failed.

* C has several types of variables, but there are a few basic types:
  * **Integers** - whole numbers which can be either positive or negative. Defined using `char`, `int`, `short`, `long` or `long long`.
  * **Unsigned integers** - whole numbers which can only be positive. Defined using unsigned `char`, `unsigned int`, `unsigned short`, `unsigned long` or `unsigned long long`.
  * **Floating point numbers** - real numbers (numbers with fractions). Defined using `float` and `double`.

* C has both one- and multidimensional arrays
* Strings in C are actually arrays of characters. 
  * `char * name = "John Smith";` can be use for reading only
  * `char name[] = "John Smith";` can be manipulated

* C functions are simple, but because of how C works, the power of functions is a bit limited.
  * Functions receive either a fixed or variable amount of arguments.
  * Functions can only return one value, or return no value.
  * Define functions like this:
    ```c
    int foo(int bar) {
      /* do something */
      return bar * 2;
    }

    int main() {
        foo(1);
    }
    ```
* **static variables** By default, variables are local to the scope in which they are defined. Variables can be declared as static to increase their scope up to file containing them. As a result, these variables can be accessed anywhere inside a file.

* **A pointer** is essentially a simple integer variable which holds a memory address that points to a value, instead of holding the actual value itself.
  * From [learn-c.org](https://www.learn-c.org/en/Pointers)
    ![](https://cd.sseu.re/Pointers_-_Learn_C_-_Free_Interactive_C_Tutorial_2018-09-27_12-30-46.png)
  * **Dereferencing** is the act of referring to where the pointer points, instead of the memory address.

# Imperative & Declarative programming languages

* C is an imperative programming language.
  * it is sequential

* Imperative vs Declarative language
  | .|Imperative|Declarative|
  |---|---|---|
  |**language example** | C | SQL |
  |**instructions focus**|What computer should do, step by step | What result should be like |
  | **state management** | program is state ( for example, developer has to define scope)| developer does not have to define state/scope themselves|

> 🎓 See more info on imperative vs declarative programming [here](https://medium.com/front-end-hacking/imperative-versus-declarative-code-whats-the-difference-adc7dd6c8380)

* Structural Programming
  * Especially important for declarative programming languages, since you can't adjust the scope of your variables too much.
  * How to structure your program such a way that you can mathematically can prove it is correct
  * Procedural programming is a style of programming where you put everything in modules and put your state as much as possible in procedures (functions).


> 🎓 Read more about [Edgar Dijkstra and the go-to statement](https://homepages.cwi.nl/~storm/teaching/reader/Dijkstra68.pdf), an example of an academic discussion about structural programming

> 🎓 See [this cool presentation about procedural programming](https://prezi.com/gaq2b6rm5h_a/basics-of-procedural-programming/)
