string[,] user =
{
    {"Max","max12310" },
    {"glezel","glezel12310" },
    {"ralph","ralph12310" },
    {"nina","nina12310" },
    {"andrea","andrea12310" },
    {"power","power12310" },
    {"hyper","hyer12310" },
    {"egul","egul12310" },
};

int i = 1;
foreach(string j in user)
{
    Console.WriteLine(j);
    if (i % user.GetLength(1) == 0) Console.WriteLine();
    i++;
}