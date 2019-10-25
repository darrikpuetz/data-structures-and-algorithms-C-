# Array Shift

## Perfect Sequence
*Author: Darrik Puetz*

---

### Problem Domain

Write the following methods for the Linked List class:

.append(value) which adds a new node with the given value to the end of the list

.insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node

.insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node


Write a function called mergeLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

---
### Summary
These methods search a link list to find a place to insert, before, after, and in the middle of that linked list. The last method is to merge the two link list.

### Inputs and Expected Outputs

| Input           | Expected Output     |
| :-----------    | :-----------         |
| [1,2,3,4], 5    | [1,2,3,4,5}         |
| [1,2,3,4,5],0,5 | [1,2,3,4,0,5       |




### Big O


| Time   | Space   |
| 5 hours| 4 hours |
| O(n)   | O(n)    |


---


### Whiteboard Visual
![Image 1](https://github.com/darrikpuetz/data-structures-and-algorithms-C-DOTNET-/blob/master/assets/LinkListInsert.jpg)
![Image 1](https://github.com/darrikpuetz/data-structures-and-algorithms-C-DOTNET-/blob/master/assets/LinkListInsert.jpg)


---

### Change Log

1.2: Turn in for Merge Linked List- 25OCT2019 
1.1: Original turn in for Linked List- 22OCT2019 

---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
