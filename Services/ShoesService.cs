using OnlineShop.Models;

namespace OnlineShop.Services;
public static class ShoesService
{
    static List<Shoes> Shoes { get; }
    static int nextId = 3;
    static ShoesService()
    {
        Shoes = new List<Shoes>
                {
                    new Shoes { Id = 1, Name = "Knee High Boots", Price=20.00M, Size=ShoesSize.Large},
                    new Shoes { Id = 2, Name = "Wellington Boots", Price=15.00M, Size=ShoesSize.Small}
                };
    }

    public static List<Shoes> GetAll() => Shoes;

    public static Shoes? Get(int id) => Shoes.FirstOrDefault(p => p.Id == id);

    public static void Add(Shoes shoe)
    {
        shoe.Id = nextId++;
        Shoes.Add(shoe);
    }

    public static void Delete(int id)
    {
        var shoe = Get(id);
        if (shoe is null)
            return;

        Shoes.Remove(shoe);
    }

    public static void Update(Shoes shoe)
    {
        var index = Shoes.FindIndex(p => p.Id == shoe.Id);
        if (index == -1)
            return;

        Shoes[index] =shoe;
    }
                }