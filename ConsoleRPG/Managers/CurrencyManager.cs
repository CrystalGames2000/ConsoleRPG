public static class CurrencyManager
{
    public static double ConvertToCP(Currency currency, double amount) {
        if (currency == Currencies.copper) return amount;
        else if (currency == Currencies.silver) return amount * 10;
        else if (currency == Currencies.gold) return amount * 100;
        else if (currency == Currencies.platinum) return amount * 1000;
        else return 0;
    }
    public static double ConvertToSP(Currency currency, double amount) {
        if (currency == Currencies.copper) return amount * 0.1;
        else if (currency == Currencies.silver) return amount;
        else if (currency == Currencies.gold) return amount * 10;
        else if (currency == Currencies.platinum) return amount * 100;
        else return 0;
    }
    public static double ConvertToGP(Currency currency, double amount) {
        if (currency == Currencies.copper) return amount * 0.01;
        else if (currency == Currencies.silver) return amount * 0.1;
        else if (currency == Currencies.gold) return amount;
        else if (currency == Currencies.platinum) return amount * 10;
        else return 0;
    }
    public static double ConvertToPP(Currency currency, double amount) {
        if (currency == Currencies.copper) return amount * 0.001;
        else if (currency == Currencies.silver) return amount * 0.01;
        else if (currency == Currencies.gold) return amount * 0.1;
        else if (currency == Currencies.platinum) return amount;
        else return 0;
    }
}
