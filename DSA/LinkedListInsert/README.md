# Linked List Insertion


*Author: Darrik Puetz*

---

### Problem Domain

Write the following methods for the Linked List class:


1. .append(value) which adds a new node with the given value to the end of the list
2. .insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node
3. .insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node
4. Write a method for the Linked List class which takes a number, k, as a parameter. Return the node’s value that is k from the end of the linked list. 
You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.



Write a function called mergeLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

---
### Summary

New methods modify a linked list added values to the head. You can insert them at the end, beginning, and anywehre else. On the second day we added a method that tracks the end of the node from where its located at.


### Inputs and Expected Outputs

| Input             | Expected Output       |
| :-----------      | :-----------          |
| [1,2,3,4], 5      | [1,2,3,4,5]           |
| [1,2,3,4,5], 0, 5 |[1,2,3,4,0,5]          |
| [1,2],[4,5,6]     |[1,4,2,5,6]       vv   |

=======
.append(value) which adds a new node with the given value to the end of the list

.insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node

.insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node

Write a method for the Linked List class which takes a number, k, as a parameter. Return the node’s value that is k from the end of the linked list. 
You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.


### Big O


| Time   | Space   |
| 9 hours| 6 hours |
| O(n)   | O(n)    |


---


### Whiteboard Visual
![Image 1](https://github.com/darrikpuetz/data-structures-and-algorithms-C-DOTNET-/blob/master/assets/LinkListInsert.jpg)

![Image 1](https://github.com/darrikpuetz/data-structures-and-algorithms-C-DOTNET-/blob/master/assets/LinkListInsert.jpg)

![Image 1](https://github.com/darrikpuetz/data-structures-and-algorithms-C-DOTNET-/blob/master/assets/LinkListWB2.jpg)




---

### Change Log


1.2: Turn in for Merge Linked List- 25OCT2019 
1.1: Original turn in for Linked List- 22OCT2019 


---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
