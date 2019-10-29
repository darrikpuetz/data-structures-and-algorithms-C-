# Array ShiftStack and Queue


*Author: Darrik Puetz*

---

### Problem Domain

Create a brand new PseudoQueue class. Do not use an existing Queue. Instead, this PseudoQueue class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 Stack objects. Ensure that you create your class with the following methods:

enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.
dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.
The Stack instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.
---
### Summary
Dequeue Method takes a value out of the stack thats on the top. Enqueue inserts one into that position.

### Inputs and Expected Outputs

| Input          | Expected Output       |
| :-----------   | :-----------          |
| [1,2,3], 5 | [1,2,3,5]   enqueue       |
| [1,2,3], 3 | [1,2,]      dequeue       |


---

### Big O


| Time   | Space   |
| 2 Hours| 4 hours |
| O(n)   | O(n)    |


---


### Whiteboard Visual
![Image 1](https://via.placeholder.com/750x500)


---

### Change Log

1.1: Original turn in for Stack and Queue- 29OCT2019 

---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet