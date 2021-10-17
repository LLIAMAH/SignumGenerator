namespace SignumLib.Tincture
{
    public enum SignumBasePattern
    {
        Default,
        StripesHorizontal,
        StripesVertical,
        StripesPal,
        StripesBar,
        HonoraryHead, // Chef Сверху щита — глава (фр. chef) шириной в 2/7 щита
        HonoraryBelt, // * Посреди щита горизонтально — пояс (фр. fasce); два узких пояска; поясок
        HonoraryEnd, // Champagne, Линия, соединяющая боковые кромки щита на высоте, равной 2/7 ширины щита — оконечность (фр. champagne). 
        HonoraryPalNormal, // * Вертикально — столб (фр. pal); узкие столбы; если столб отнесен к правой или левой стороне щита, он называется край (фр. flanc)
        HonoraryPalTight, // * Вертикально — столб (фр. pal); узкие столбы; 
        // ReSharper disable once IdentifierTypo
        HonoraryFlancLeft, // если столб отнесен к правой или левой стороне щита, он называется край (фр. flanc)
        // ReSharper disable once IdentifierTypo
        HonoraryFlancRight, // если столб отнесен к правой или левой стороне щита, он называется край (фр. flanc)
        HonorarySlingLeft, // * Наискосок — перевязь справа (фр. bande); три узкие перевязи справа; тонкая перевязь справа; перевязь слева (фр. barre); две узкие перевязи слева
        HonorarySlingRight, // * Наискосок — перевязь справа (фр. bande); три узкие перевязи справа; тонкая перевязь справа; перевязь слева (фр. barre); две узкие перевязи слева
        HonoraryChevron, //  * В виде буквы Л (перевёрнутой V) — стропило (фр. chevron); три узких стропила
        HonoraryChevronInverse,

        // ReSharper disable once IdentifierTypo
        HonoraryCroix, //* Кресты: прямой крест (фр. croix); прямой узкий крест; косой крест (фр. sautoir); 
        // ReSharper disable once IdentifierTypo
        HonoraryCroixDiagonal, // узкий косой крест (андреевский); вилообразный крест (фр. pairle); узкий вилообразный крест

        /*
         * Кайма (фр. bordure) — окаймление вокруг края щита. В испанской и португальской геральдике включает в себя уменьшенные щиты близких родственников. Также см. бризуры.
         * Костыль (фр. chef-pal) — комбинация столба и главы
         */
        Quarter,
        Quarters_1_4,
        Quarters_2_3,
        QuartersDiagonalTopBottom,
        QuartersDiagonalLeftRight,
        CheckersNormal,
        CheckersInverse,
        CheckersDiagonal,
        ChevronMiddleNormal,
        ChevronMiddleInvert,
        ChevronFullNormal,
        ChevronFullInvert,
        ChevronPointOffsetSizeNormal,
        ChevronPointOffsetSizeInvert,
        SplitHorizontalNormal,
        SplitHorizontalInvert,
        SplitVerticalLeft,
        SplitVerticalRight,
        SliceLeftNormal,
        SliceLeftInvert,
        SliceRightNormal,
        SliceRightInvert
    }
}
