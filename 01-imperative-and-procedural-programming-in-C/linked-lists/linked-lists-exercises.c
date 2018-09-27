// Write a C program that initializes a doubly linked list 
// (a linked list that has a reference to the next AND previous element), of 
// 100 elements where each node contains an integer value between 0 and 99, 
// randomly initialized. The program must get 2 numbers as input from the console 
// and add the first number at the beginning of the list and the second number of 
// the end of the list. Print the modified linked list to the console such that is 
// looks like this: 
// Head[value]<->Node[value]<->Node[value]<->Node[value]... <->Tail[value]
#include <stdio.h>
#include <stdlib.h>

// Define what each element in the list should look like
typedef struct node {
    int val;
    struct node * next;
} node_t;

//function to print the list
void print_list(node_t * head) {
    node_t * current = head;

    while (current != NULL) {
        printf("%d\n", current->val);
        current = current->next;
    }
}

// function to add a value to the end of the list
void push(node_t * head, int val) {
    node_t * current = head;
    while (current->next != NULL) {
        current = current->next;
    }

    /* now we can add a new variable */
    current->next = malloc(sizeof(node_t));
    current->next->val = val;
    current->next->next = NULL;
}

int main() {

    // set up head initial list
    node_t * test_list = malloc(sizeof(node_t));
    test_list->val = 0;
    test_list->next = NULL;

    // call function (100 times)
    int i;
    for(i = 1; i < 100; i++){
        push(test_list, i);
    }

    print_list(test_list);
}
