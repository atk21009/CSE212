# Tree Problem Example

## Problem

In this problem we are adding the football roster of the Kansas City Chiefs roster 2023.
We want to be able to add the roster in any order and have it returned in order by the players number.
We are also keeping track of the player's first name and last name. We also want to return the size of the tree.

## Approach

### Binary Tree

In this problem we want to use a binary tree in order to accomplish this goal.
With binary trees we are able to sort the players number in order.
We are also able to return the players information in order of players numbers.

## Methods

### Node

---- 

In this file we initialize the node we are going to use. We are using a tuple as a node in order to store the players number, first name, and last name

#### Insert

The insert method finds the value of the players number and traverses down the tree left or right depending if the number is greater than the current node its comparing to.

### FootballRosterTree

----

In this file we initialize the tuple we will be storing out data in, and initializing the root of the tree.
In addition to this we also have the insert, TraverseForward, MaxDepth, and GetEnumerator methods.

#### Insert

The insert method used in this file is used to enter the data given into a tuple, and determine if the root is null or not.
If the root is null it creates a new root for the tree. However, if the root is not null its inserts the node into the already existing tree.

#### MaxDepth

In the MaxDepth method we traverse over the entire tree to check to see which path is the longest. We then calculate the length of the tree.
Once we do that we return the value of the length.

#### TraverseForward

In the TraverseForward method we use to read each node of the tree. The data from the node is then entered into a list and returns the list.
We use this method in correlation with the GetEnumerator method.

#### GetEnumerator

In the GetEnumerator method we gather the list from the TraverseForward method and return the players information to be printed.

### TreeTester

----

In this file we insert all the football players number, first name, and last name into the tree.
We also loop over the tree and print out each players information. We also print out the longest branch of the tree
or in other words the height of the tree.