using OnlineShop.Models;

namespace OnlineShop.Services;
public static class ShoeService
{
    static List<Shoe> Shoes { get; }
    static int nextId = 3;
    static ShoesService()
    {
        Shoes = new List<Shoe>
                {
                    new Shoe { Id = 1, Name = "Knee High Boots", Price=20.00M, Size=ShoeSize.Large},
                    new Shoe { Id = 2, Name = "Wellington Boots", Price=15.00M, Size=ShoeSize.Small}
                };
    }

    public static List<Shoe> GetAll() => Shoes;

    public static Shoe? Get(int id) => Shoes.FirstOrDefault(p => p.Id == id);

    public static void Add(Shoe shoe)
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

    public static void Update(Shoe shoe)
    {
        var index = Shoes.FindIndex(p => p.Id == shoe.Id);
        if (index == -1)
            return;

        Shoes[index] =shoe;
    }
                }