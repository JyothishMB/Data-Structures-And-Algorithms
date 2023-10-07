'use strict';

import chalk from 'chalk';


class Node {
    constructor(value) {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}

class BinarySearchTree {
    constructor() {
        this.root = null;
    }
    insert(value) {
        let newnode = new Node(value);
        if (this.root === null) {
            this.root = newnode;
        }
        else {
            let current = this.root
            while (current != null) {
                if (newnode.value > current.value) {
                    if (current.right == null) {
                        current.right = newnode;
                        break;
                    }
                    current = current.right
                }
                else {
                    if (current.left == null) {
                        current.left = newnode;
                        break;
                    }
                    current = current.left;
                }
            }
        }
    }
    lookup(value) {
        let currentnode = this.root;
        while (currentnode != null) {
            if (value > currentnode.value) {
                currentnode = currentnode.right
            }
            else if (value < currentnode.value) {
                currentnode = currentnode.left;
            }
            else if (value == currentnode.value) {
                return currentnode;
            }
        }
    }
    remove(value) {
        let currentnode = this.root;
        let parentnode = null
        while (currentnode != null) {
            if (value > currentnode.value) {
                parentnode = currentnode;
                currentnode = currentnode.right
            }
            else if (value < currentnode.value) {
                parentnode = currentnode;
                currentnode = currentnode.left;
            }
            else if (value == currentnode.value) {
                //If value identified, 
                if (currentnode.right == null) {
                    //Option 1. No right child.
                    if (parentnode == null) {
                        this.root = currentnode.left;
                    }
                    else if (currentnode.value < parentnode.value) {
                        parentnode.left = currentnode.left
                    }
                    else if (currentnode.value > parentnode.value) {
                        parentnode.right = currentnode.left;
                    }
                }
                else if (currentnode.right.left == null) {
                    //Option 2. right child doesnt have a left child.
                    currentnode.right.left = currentnode.left;
                    if (parentnode === null) {
                        this.root = currentnode.right;
                    } else {

                        //if parent > current, make right child of the left the parent
                        if (currentnode.value < parentnode.value) {
                            parentnode.left = currentnode.right;

                            //if parent < current, make right child a right child of the parent
                        } else if (currentnode.value > parentnode.value) {
                            parentnode.right = currentnode.right;
                        }
                    }
                }
                else {
                    //Option 3. right child have a left child.
                    //find the Right child's left most child
                    let leftmost = currentNode.right.left;
                    let leftmostParent = currentNode.right;
                    while (leftmost.left !== null) {
                        leftmostParent = leftmost;
                        leftmost = leftmost.left;
                    }

                    //Parent's left subtree is now leftmost's right subtree
                    leftmostParent.left = leftmost.right;
                    leftmost.left = currentNode.left;
                    leftmost.right = currentNode.right;

                    if (parentNode === null) {
                        this.root = leftmost;
                    } else {
                        if (currentNode.value < parentNode.value) {
                            parentNode.left = leftmost;
                        } else if (currentNode.value > parentNode.value) {
                            parentNode.right = leftmost;
                        }
                    }
                }
                return true;
            }
        }
    }

}

console.log(chalk.blue('Initialising tree...'));
const tree = new BinarySearchTree();
tree.insert(9);
tree.insert(4);
tree.insert(6);
tree.insert(20);
tree.insert(170);
tree.insert(15);
tree.insert(1);


console.log(chalk.green('Insert completed.'));
console.log(JSON.stringify(tree.root));

tree.remove(170)
console.log(chalk.red('Removed 170'));
console.log(JSON.stringify(tree.root));

let searchednode = tree.lookup(20);
console.log(chalk.blue('Searched and found 20'));
console.log(JSON.stringify(searchednode))

console.log(chalk.yellow('Press any key to exit'));

process.stdin.setRawMode(true);
process.stdin.resume();
process.stdin.on('data', process.exit.bind(process, 0));
