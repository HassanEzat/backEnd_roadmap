namespace Recap.Library;

internal class Member
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Member(int id,string name )
    {
        if (id < 1) throw new ArgumentOutOfRangeException(nameof(id),"can not be below 1");
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("can not be space or empty",nameof(name));
        this.Id = id;
        this.Name = name.Trim();
    }

}
