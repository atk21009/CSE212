# Tree Example

## Phone number tree example

In this project we store phone numbers into a tree and sort the numbers as we enter them.

### Goal
To store Phone Numbers and sort them in a tree

### Tree type
Binary Tree

## Methods

### BinarySearchTree.cs

* Insert
    * Remove hyphens from string
    * Tests to see if the phone number is formatted correctly. ex. xxx-xxx-xxxx.
    * Test to see if tree exists, if not it creates a new root. Otherwise it inserts the node.

* MaxDepth
    * Traverse through all paths of the tree to determine the max height of the tree

### Node

* Insert
    * Tests to see whether to take left path or right path
    * Recurs till finds null spot and inserts itself
