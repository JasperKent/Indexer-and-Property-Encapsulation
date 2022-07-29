using IndexerEncapsulation;

try
{
    //Scores skating = new Scores(9, 1, 6);

    //skating[0] = 4;
    //skating[1] = 5;
    //skating[2] = 5;
    //skating[3] = 6;
    //skating[4] = 3;
    //skating[5] = 4;
    //skating[6] = 3;
    //skating[7] = 6;
    //skating[8] = 14;

    //Console.WriteLine($"Skating max is {skating.MaxScore}");

    Panel dancing = new Panel(4, 1, 10);

    dancing[0] = new Panelist ("Bruno Tonioli",  8 );
    dancing[1] = new Panelist ("Arlene Phillips",  9 );
    dancing[2] = new Panelist ("Len Goodman",  10 );
    dancing[3] = new Panelist ("Alesha Dixon",  8 );

    Console.WriteLine($"Dancing max is {dancing.MaxScore}");

   // dancing[3].Score = 27;

   // Console.WriteLine($"Dancing max is {dancing.MaxScore}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}