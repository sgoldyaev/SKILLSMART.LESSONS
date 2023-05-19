namespace AlgorithmsDataStructures;

public static class Lab1Bonus
{
    public static LinkedList Merge(LinkedList left, LinkedList right)
    {
        LinkedList result = new LinkedList();

        if (left?.Count() > 0 && right?.Count() > 0 && left.Count() == right.Count())
        {
            Node l = left.head;
            Node r = right.head;

            while (l != null && r != null)
            {
                result.AddInTail(new Node(l.value + r.value));

                l = l.next;
                r = r.next;
            }
        }

        return result;
    }
}
