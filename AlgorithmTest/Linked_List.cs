using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    public class Node
    {
        public int key;
        public object value;
        public Node next;

        public Node (int key, object value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }

    class Linked_List
    {
        Node head;

        /* Inserts a new Node at front of the list. */
        public void InsertNodeAtBegin(int key, object value)
        {
            Node newNode = new Node(key, value);
            newNode.next = this.head;
            head = newNode;
        }

        public void InsertAtIndex(int index, int key, object value)
        {
            int i = 1;

            Node temp = this.head;
            Node prev;
            Node newNode = new Node(key, value);

            if (index == 0)
            {
                InsertNodeAtBegin(key, value);
                return;
            }
            while ((i != index)&& (temp!=null))
            {
                temp = temp.next;
                i++;
            }

            if (temp == null) return;

            prev = temp.next;
            temp.next = newNode;
            newNode.next = prev;
        }

        public void PrintList ()
        {
            Node temp = this.head;
            Console.WriteLine("");
            while (temp != null)
            {
                Console.WriteLine($"{temp.key} : {temp.value}");
                temp = temp.next;
            }
            Console.WriteLine("Done");
        }

        public void InsertNodeAtEnd(int key, object value)
        {
            Node newNode = new Node(key, value);
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }

        public void DeleteNode (int key)
        {
            Node temp = this.head;
            Node prev = this.head;

            if (this.head.key == key)
            {
                this.head = temp.next;
                return;
            }

            while ((temp.key != key) && (temp!= null))
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null) return;

            prev.next = temp.next;

        }

        public static void CallLinkedList()
        {
            Linked_List linkList = new Linked_List();

            linkList.InsertNodeAtBegin(1, "Nathan");
            linkList.InsertNodeAtBegin(2, "Ady");
            linkList.InsertNodeAtBegin(3, "Tafika");
            linkList.InsertNodeAtEnd(4, "Adrien");
            linkList.InsertNodeAtEnd(5, "Thierry");
            linkList.PrintList();
            linkList.InsertAtIndex(5, 6, "Inserido");
            linkList.PrintList();
            linkList.DeleteNode(2);
            linkList.PrintList();
        }
    }

}
