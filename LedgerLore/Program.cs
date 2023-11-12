const string encryptedFlag = "Dg0CDA==";

var balanceSheets = new List<BalanceSheet>
{
    new BalanceSheet(2000, 9930716m, 5054884m, 4875767m),
    new BalanceSheet(2001, 9950641m, 4971891m, 4978750m),
    new BalanceSheet(2002, 9988726m, 4942293m, 5046364m),
    new BalanceSheet(2003, 9924017m, 5017876m, 4906141m),
    new BalanceSheet(2004, 9971591m, 5054085m, 4917506m),
    new BalanceSheet(2005, 10012029m, 5065473m, 4946556m),
    new BalanceSheet(2006, 9998471m, 4999261m, 4999210m),
    new BalanceSheet(2007, 10006690m, 4972848m, 5033842m),
    new BalanceSheet(2008, 10037822m, 4965751m, 5072071m),
    new BalanceSheet(2009, 9958034m, 4987191m, 4970843m),
    new BalanceSheet(2010, 9954268m, 5026758m, 4927428m),
    new BalanceSheet(2011, 9936728m, 4940482m, 4996246m),
    new BalanceSheet(2012, 10003123m, 5055974m, 4947149m),
    new BalanceSheet(2013, 9903672m, 5019505m, 4884167m),
    new BalanceSheet(2014, 10017934m, 5054314m, 4963531m),
    new BalanceSheet(2015, 10033257m, 4945738m, 5087519m),
    new BalanceSheet(2016, 10070705m, 5069407m, 5001298m),
    new BalanceSheet(2017, 9925696m, 4941428m, 4984268m),
    new BalanceSheet(2018, 10060389m, 4997789m, 5062600m),
    new BalanceSheet(2019, 10025958m, 5072615m, 4953343m),
    new BalanceSheet(2020, 9924195m, 5068455m, 4855740m),
    new BalanceSheet(2021, 10023124m, 5069968m, 4953156m),
    new BalanceSheet(2022, 9939940m, 4938686m, 5001254m),
    new BalanceSheet(2023, 9959043m, 4940455m, 5018588m),
};

foreach(var balanceSheet in balanceSheets)
{
    Console.WriteLine($"Balance Sheet Analysis {balanceSheet.Year}:");
    Console.WriteLine($"Assets: {balanceSheet.Assets}");
    Console.WriteLine($"Liabilities: {balanceSheet.Liabilities}");
    Console.WriteLine($"Equity: {balanceSheet.Equity}");
    Console.WriteLine();
}

// Once you have identified the key, you can decrypt the flag
//var decryptedFlag = Decryptor.Decrypt(encryptedFlag, key);
//Console.WriteLine("Decrypted Flag: " + decryptedFlag);

internal record BalanceSheet(int Year, decimal Assets, decimal Liabilities, decimal Equity);
