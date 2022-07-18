public class Tree
{
    public Tree(string name, List<Tree> children)
    {
        Name = name;
        Children = children;
    }

    public string Name { get; set; }
    public IEnumerable<Tree> Children { get; set; }

    public void GetAllNames(Tree tree, List<string> result)
    {
        result.Add(tree.Name);

        if (tree.Children == null)
        {
            return;
        }

        foreach (var child in tree.Children)
        {
            GetAllNames(child, result);
        }
    }
}