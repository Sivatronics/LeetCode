using LeetCode;

namespace LeetCodeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}

        [Test]
        public void Test_Merge2LinkedList()
        {
            LinkedList input1 = new LinkedList(1);
            addMany(input1, new List<int> { 3, 5, 7,8 });
            LinkedList input2 = new LinkedList(2);
            addMany(input2, new List<int> { 4, 6, 8 });

            List<int> expectedNodes = new List<int> { 1, 2, 3, 4, 5, 6, 7,8,8 };
            LinkedList output = new LeetCode.LeetCode().MergeTwoLinkedLists(input1, input2);
            Assert.True(Enumerable.SequenceEqual(getNodesInArray(output), expectedNodes));
        }

        [Test]
        public void Test_RemoveDuplicatesFromLinkedList()
        {
            LinkedList input = new LinkedList(1);
            addMany(input, new List<int> {
            1,3,4,4,4,5,6,6
        });
            List<int> expectedNodes = new List<int> {
                1, 3, 4, 5, 6
        };
            LinkedList output = new LeetCode.LeetCode().RemoveDuplicatesFromLinkedList(input);
            Assert.True(Enumerable.SequenceEqual(getNodesInArray(output), expectedNodes));
        }
        public LinkedList addMany(LinkedList ll, List<int> values)
        {
            LinkedList current = ll;
            while (current.next != null)
            {
                current = current.next;
            }
            foreach (var value in values)
            {
                current.next = new LinkedList(value);
                current = current.next;
            }
            return ll;
        }

        public List<int> getNodesInArray(LinkedList ll)
        {
            List<int> nodes = new List<int>();
            LinkedList current = ll;
            while (current != null)
            {
                nodes.Add(current.value);
                current = current.next;
            }
            return nodes;
        }
    }
}