
PriorityQueue<string, int>? queue = new PriorityQueue<string , int>();
queue.Enqueue("Pedro1", 5);
queue.Enqueue("Pedro2", 1);
queue.Enqueue("Pedro3", 3);
queue.Enqueue("Pedro", 0);

while (queue.TryDequeue(
    out string? item,
    out int priority))
{
    Console.WriteLine($"{item} - {priority}");
}

PriorityQueue<Student, string>? queueTest = new PriorityQueue<Student, string>(new RoleComparer());
queueTest.Enqueue(new Student("Pedro1"), "student");
queueTest.Enqueue(new Student("Pedro2"), "premium");
queueTest.Enqueue(new Student("Pedro0"), "admin");
queueTest.Enqueue(new Student("Pedro"), "classic");


while (queueTest.TryDequeue(
    out var student,
    out var priority))
{
    Console.WriteLine($"{student.name} - {priority}");
}

public record Student (string name);

public class RoleComparer : IComparer<string>
{
    public int Compare(string? roleA, string? RoleB)
    {
        if (roleA == RoleB)
            return 0;

        return roleA switch
        {
            "admin" => -1,
            "premium" => -2,
            _ => 1,
        };
    }
}