# LinkedListProblem
This project is a representative of internet search history. In which we are able to traverse forwards and backwards on our list to visit different sites. We use various methods to add, remove, clear, etc to our linked list. We are able to represent our search history with linked lists and traverse through our search history.

## Linked List Methods

### InsertHead
    Inputs: string website

In this method we create a new head for the linked list and connect the new head to the old head

### InsertTail
    Inputs: string website

In this method we create a new tail for the linked list and connect the new tail to the old tail

### RemoveHead
    Inputs: None

In this method we remove the head of the linked list and set the next node as the head

### RemoveTail
    Inputs: None

In this method we remove the tail of the linked list and set the previous node as the tail

### InsertAfter
    Inputs: string website, string newWebsite

In this method we loop through the linked list to find the node with the data of website, after we have located the node we create a new node after the node with the value of newWebsite

### Remove
    Inputs: string value

In this method we loop through the linked list to find the node with the data of value, after we have located it we remove the node and connect the previous node and next node together

### ClearList
    Inputs: None

In this method we loop through the linked list removing each node of the linked list. In which we essentially clear our search history.