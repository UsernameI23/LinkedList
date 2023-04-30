using System.Security.Cryptography.X509Certificates;

public class Example
{
    public static void Main()
    {
       
        string[] members =
            { "Kate", "Jane", "Sarah", "Lily", "April", "Hannah" };
        LinkedList<string> memberList = new LinkedList<string>(members);
        Console.WriteLine("Original member list");
        foreach (string member in memberList)
        {
            Console.WriteLine(member);
        }
        Console.WriteLine();


        
        LinkedListNode<string> targetLocation = memberList.Find("Kate");
        Console.WriteLine($"First Member of the list is {members[0]}");
        LinkedListNode<string> targetLocation2 = memberList.FindLast("Hannah");
        Console.WriteLine($"Last Member of the list is {members[5]}");

        memberList.AddAfter(targetLocation, "Paul");
        memberList.Remove("Jane");

        //memberList.AddAfter(targetLocation2, "Anna");
        //memberList.Remove("Jane");
        Console.WriteLine();
        Console.WriteLine($"Here are the available members: {members.Count()}");


        string[] memberArray = new string[memberList.Count];
        memberList.CopyTo(memberArray, 0);

       

        Console.WriteLine("Here are the changes to the List");
        foreach (string f in memberArray)
        {
            Console.WriteLine(f);
        }

        
        memberList.Clear();


    }

}
