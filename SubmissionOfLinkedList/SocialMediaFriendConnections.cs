using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    // Node representing a user in the social media friend connections
    class UserNode
    {
        public int UserID;
        public string Name;
        public int Age;
        public List<int> FriendIDs;
        public UserNode Next;

        public UserNode(int userID, string name, int age)
        {
            UserID = userID;
            Name = name;
            Age = age;
            FriendIDs = new List<int>();
            Next = null;
        }
    }

    class SocialMediaFriendConnections
    {
        private UserNode head = null;

        // Add a new user
        public void AddUser(int userID, string name, int age)
        {
            UserNode newNode = new UserNode(userID, name, age);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                UserNode temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = newNode;
            }
        }

        // Add a friend connection between two users
        public void AddFriend(int userID1, int userID2)
        {
            UserNode user1 = FindUser(userID1);
            UserNode user2 = FindUser(userID2);
            if (user1 != null && user2 != null && !user1.FriendIDs.Contains(userID2))
            {
                user1.FriendIDs.Add(userID2);
                user2.FriendIDs.Add(userID1);
            }
        }

        // Remove a friend connection
        public void RemoveFriend(int userID1, int userID2)
        {
            UserNode user1 = FindUser(userID1);
            UserNode user2 = FindUser(userID2);
            if (user1 != null && user2 != null)
            {
                user1.FriendIDs.Remove(userID2);
                user2.FriendIDs.Remove(userID1);
            }
        }

        // Find mutual friends between two users
        public void FindMutualFriends(int userID1, int userID2)
        {
            UserNode user1 = FindUser(userID1);
            UserNode user2 = FindUser(userID2);
            if (user1 != null && user2 != null)
            {
                List<int> mutualFriends = user1.FriendIDs.FindAll(id => user2.FriendIDs.Contains(id));
                Console.WriteLine($"Mutual friends of {user1.Name} and {user2.Name}: {string.Join(", ", mutualFriends)}");
            }
        }

        // Display all friends of a specific user
        public void DisplayFriends(int userID)
        {
            UserNode user = FindUser(userID);
            if (user != null)
            {
                Console.WriteLine($"Friends of {user.Name}: {string.Join(", ", user.FriendIDs)}");
            }
        }

        // Search for a user by User ID or Name
        public UserNode FindUser(int userID)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.UserID == userID)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        public UserNode FindUser(string name)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        // Count the number of friends for each user
        public void CountFriends()
        {
            UserNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"{temp.Name} has {temp.FriendIDs.Count} friends.");
                temp = temp.Next;
            }
        }
    }

}
