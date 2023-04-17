# LinkedListExample
In this project we use a linked list to store songs in queue so that we can see songs we've listened to and songs we have queued.

## LinkedList.cs
This file contains the bulk of the code to make the linked list work. In this file we use various different methods to add and remove songs from our queue.

### Insert Tail
    Inputs: string song

In this method we add songs into our queue at the end of the linked list

### Remove head
    Inputs: None

This method is used to remove the node at the beginning of the linked list

### Remove tail
    Inputs: None

This method is used to remove the node at the end of the linked list

### Insert After
    Inputs: string song, string newSong

In this method we loop over the linked list and search for the song value in the linked list. Once we find the value we create a new node after the value and set the value to the newSong.

### Remove
    Inputs: string value

In this method we once again loop over the linked list. We search for the node with the value of our input and remove that node from the linked list and connect the two nodes before and after to one another.