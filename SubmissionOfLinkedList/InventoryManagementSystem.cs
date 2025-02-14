using System;


namespace SubmissionOfLinkedList
{
    public class InventoryNode
    {
        public string name;
        public int itemId;
        public int quantity;
        public double price;
        public InventoryNode next;

        public InventoryNode(string name, int itemId, int qunatity, double price)
        {
            this.name = name;
            this.itemId = itemId;
            this.quantity = quantity;
            this.price = price;
            next = null;
        }

    }
    public class InventoryManagementSystem
    {
        public InventoryNode  head;
        //method which is used to add the element in the begning
        public void AddFirst(string name, int itemId, int quantity, double price)
        {
            InventoryNode newItem = new InventoryNode(name, itemId, quantity, price);
            if(head == null)
            {
                head = newItem;
                Console.WriteLine("New Item Added in the list Name is: "+name+" ItemId is: "+itemId+" Quantity is: "+quantity+" price "+price);
                return;

            }
            else
            {
                newItem.next = head;
                head = newItem;
                Console.WriteLine("New Item Added in the list Name is: " + name + " ItemId is: " + itemId + " Quantity is: " + quantity + " price " + price);

            }
            Console.WriteLine("--------------------------------------");

        }

        public void AddLast(string name, int itemId, int quantity, double price)
        {

            InventoryNode newItem = new InventoryNode(name, itemId, quantity,price);
            if(head == null)
            {
                head = newItem;
                Console.WriteLine("New Item Added in the list Name is: "+name+" ItemId is: "+itemId+" Quantity is: "+quantity+" price "+price);
                return;

            }
            InventoryNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;

            }
            temp.next = newItem;
            Console.WriteLine("New Item Added in the list Name is: " + name + " ItemId is: " + itemId + " Quantity is: " + quantity + " price " + price);
            Console.WriteLine("--------------------------------");
        }


        public void AddAtSpecific(string name, int itemId, int quantity, double price,int position)
        {

            InventoryNode newItem = new InventoryNode(name, itemId, quantity, price);
            {
                if(position < 1)
                {
                    Console.WriteLine("invalid Position");
                }
                if(position==1)
                {
                    newItem.next = head.next;
                    head= newItem;
                }
                if(head == null)
                {
                    head = newItem;
                    Console.WriteLine("New Item Added in the list Name is: " + name + " ItemId is: " + itemId + " Quantity is: " + quantity + " price " + price);
                    return;
                }
                InventoryNode temp = head;
                for(int i=0;i<position && temp.next!=null;i++)
                {
                    temp = temp.next;
                }
                newItem.next = temp.next;
                temp.next = newItem;
                Console.WriteLine("New Item Added in the list Name is: " + name + " ItemId is: " + itemId + " Quantity is: " + quantity + " price " + price);
            }
            Console.WriteLine("---------------------------");

        }
        

        public void RemoveId(int id)
        {
            if(head == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            if(head.itemId ==id)
            {
                head = head.next;
                Console.WriteLine("Item Deleted");
                return;
            }
            InventoryNode temp = head;
            while (temp.next != null && temp.next.itemId != id )
            {
                temp= temp.next;

            }
            if(temp.next == null)
            {
                Console.WriteLine("item not found");
                return;
            }
            temp.next = temp.next.next;
            Console.WriteLine("item deleted");
            Console.WriteLine("-----------------------------");

        }
        public void Displayitem()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            InventoryNode temp = head;
            int i = 1;
            while (temp != null)
            {
                Console.WriteLine("Item " + i + " details are " + " id is: " + temp.itemId + " Name is: " + temp.name + " quantity is: " + temp.quantity + " price is: " + temp.price);
                i++;
                temp = temp.next;
            }
            Console.WriteLine("------------------------");
        }

        public void SearchItem(int id, string name)
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            InventoryNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (id != null && temp.itemId == id)
                {
                    Console.WriteLine($"Item Found! ID: {temp.itemId}, Name: {temp.name}, Quantity: {temp.quantity}, Price: {temp.price}");
                    found = true;
                }

                //  Check by Item Name (if provided)
                if (!string.IsNullOrEmpty(name) && temp.name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Item Found! ID: {temp.itemId}, Name: {temp.name}, Quantity: {temp.quantity}, Price: {temp.price}");
                    found = true;
                }

                temp = temp.next;
            }
        }

        public void SortInventory(string criteria, bool ascending)
        {
            if (head == null || head.next == null)
            {
                Console.WriteLine("List is too small to sort.");
                return;
            }

            bool swapped;
            do
            {
                swapped = false;
                InventoryNode current = head;
                InventoryNode prev = null;

                while (current.next != null)
                {
                    bool shouldSwap = false;

                    //  Sort by Name
                    if (criteria == "name")
                    {
                        if (ascending)
                            shouldSwap = string.Compare(current.name, current.next.name, StringComparison.OrdinalIgnoreCase) > 0;
                        else
                            shouldSwap = string.Compare(current.name, current.next.name, StringComparison.OrdinalIgnoreCase) < 0;
                    }
                    //  Sort by Price
                    else if (criteria == "price")
                    {
                        if (ascending)
                            shouldSwap = current.price > current.next.price;
                        else
                            shouldSwap = current.price < current.next.price;
                    }

                    //  Swap Nodes
                    if (shouldSwap)
                    {
                        string tempName = current.name;
                        int tempId = current.itemId;
                        int tempQty = current.quantity;
                        double tempPrice = current.price;

                        current.name = current.next.name;
                        current.itemId = current.next.itemId;
                        current.quantity = current.next.quantity;
                        current.price = current.next.price;

                        current.next.name = tempName;
                        current.next.itemId = tempId;
                        current.next.quantity = tempQty;
                        current.next.price = tempPrice;

                        swapped = true;
                    }

                    prev = current;
                    current = current.next;
                }
            } while (swapped);

            Console.WriteLine($"Inventory sorted by {criteria} in {(ascending ? "ascending" : "descending")} order.");
        }


    }
}
