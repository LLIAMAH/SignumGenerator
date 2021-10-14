namespace SignumGenerator.Signum
{
    public enum SignumBasePattern
    {
        Default,
        StripesHorizontal,
        StripesVertical,
        StripesPal,
        StripesBar,
        PalNormal,
        PalTight,
        Chef, // Сверху щита — глава (фр. chef) шириной в 2/7 щита
        Champagne, //Линия, соединяющая боковые кромки щита на высоте, равной 2/7 ширины щита — оконечность (фр. champagne).
        /*
         * Сверху щита — глава (фр. chef) шириной в 2/7 щита.
         * Посреди щита горизонтально — пояс (фр. fasce); два узких пояска; поясок
         * Линия, соединяющая боковые кромки щита на высоте, равной 2/7 ширины щита — оконечность (фр. champagne). Нижняя кромка оконечности совпадает с нижней кромкой щита.
         * Вертикально — столб (фр. pal); узкие столбы; если столб отнесен к правой или левой стороне щита, он называется край (фр. flanc)
         * Наискосок — перевязь справа (фр. bande); три узкие перевязи справа; тонкая перевязь справа; перевязь слева (фр. barre); две узкие перевязи слева
         * В виде буквы Л (перевёрнутой V) — стропило (фр. chevron); три узких стропила
         * Кресты: прямой крест (фр. croix); прямой узкий крест; косой крест (фр. sautoir); узкий косой крест (андреевский); вилообразный крест (фр. pairle); узкий вилообразный крест
         * Кайма (фр. bordure) — окаймление вокруг края щита. В испанской и португальской геральдике включает в себя уменьшенные щиты близких родственников. Также см. бризуры.
         * Костыль (фр. chef-pal) — комбинация столба и главы
         */
        Quarter,
        Quarters_1_4,
        Quarters_2_3,
        QuartersDiagonalTopBottom,
        QuartersDiagonalLeftRight,
        SlingLeft,
        SlingRight,
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
