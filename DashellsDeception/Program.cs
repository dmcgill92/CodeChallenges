var financialTransactions = new List<FinancialTransaction>
{
    new FinancialTransaction(1, new List<decimal> { 3472, 123 }, new List<decimal> { 3596 }),
    new FinancialTransaction(2, new List<decimal> { 4532, 1834, 654, 83 }, new List<decimal> { 4286, 2817 }),
    new FinancialTransaction(3, new List<decimal> { 1370, 45 }, new List<decimal> { 1186, 228 }),
    new FinancialTransaction(4, new List<decimal> { 4627, 5927 }, new List<decimal> { 10553 }),
    new FinancialTransaction(5, new List<decimal> { 1748, 1359, 538 }, new List<decimal> { 783, 2861 }),
    new FinancialTransaction(6, new List<decimal> { 8429, 2490 }, new List<decimal> { 9804, 1114 }),
    new FinancialTransaction(7, new List<decimal> { 20051, 3453 }, new List<decimal> { 16052, 7452 }),
    new FinancialTransaction(8, new List<decimal> { 3417, 461 }, new List<decimal> { 886, 2991 }),
    new FinancialTransaction(9, new List<decimal> { 6483, 3963 }, new List<decimal> { 10446 }),
    new FinancialTransaction(10, new List<decimal> { 432, 3323 }, new List<decimal> { 2490, 1266 }),
    new FinancialTransaction(11, new List<decimal> { 5846, 478, 213 }, new List<decimal> { 6281, 255 }),
    new FinancialTransaction(12, new List<decimal> { 8349, 6830 }, new List<decimal> { 15180 }),
    new FinancialTransaction(13, new List<decimal> { 1326, 113 }, new List<decimal> { 1422, 16 }),
    new FinancialTransaction(14, new List<decimal> { 7311, 2732 }, new List<decimal> { 10043 }),
    new FinancialTransaction(15, new List<decimal> { 10375, 843, 155 }, new List<decimal> { 9503, 1869 }),
    new FinancialTransaction(16, new List<decimal> { 2413, 237 }, new List<decimal> { 1930, 721 }),
    new FinancialTransaction(17, new List<decimal> { 905, 153 }, new List<decimal> { 1040, 18 }),
    new FinancialTransaction(18, new List<decimal> { 1633 }, new List<decimal> { 1413, 221 }),
    new FinancialTransaction(19, new List<decimal> { 89, 1578 }, new List<decimal> { 287, 1379 }),
    new FinancialTransaction(20, new List<decimal> { 3245, 684, 9187, 62 }, new List<decimal> { 4286, 2817, 6076 }),
    new FinancialTransaction(21, new List<decimal> { 4366, 3354 }, new List<decimal> { 7720 }),
    new FinancialTransaction(22, new List<decimal> { 717, 4891 }, new List<decimal> { 546, 2331, 2730 }),
    new FinancialTransaction(23, new List<decimal> { 23347 }, new List<decimal> { 13079, 3049, 7219 }),
    new FinancialTransaction(24, new List<decimal> { 564, 3434 }, new List<decimal> { 1265, 2732 }),
    new FinancialTransaction(25, new List<decimal> { 5433, 168, 1506 }, new List<decimal> { 6563, 543 }),
    new FinancialTransaction(26, new List<decimal> { 547, 5894 }, new List<decimal> { 4832, 1609 }),
    new FinancialTransaction(27, new List<decimal> { 11233, 232 }, new List<decimal> { 2334, 7574, 1556 }),
    new FinancialTransaction(28, new List<decimal> { 13649 }, new List<decimal> { 334, 13314 }),
    new FinancialTransaction(29, new List<decimal> { 3423, 7684 }, new List<decimal> { 11106 }),
    new FinancialTransaction(30, new List<decimal> { 1312, 2342 }, new List<decimal> { 324, 3330 }),
    new FinancialTransaction(31, new List<decimal> { 1235, 265, 8732, 47 }, new List<decimal> { 4537, 186, 5555 }),
    new FinancialTransaction(32, new List<decimal> { 1138 }, new List<decimal> { 156, 983 }),
    new FinancialTransaction(33, new List<decimal> { 2398, 3598, 5098 }, new List<decimal> { 8953, 60, 2081 }),
    new FinancialTransaction(34, new List<decimal> { 458, 5403 }, new List<decimal> { 948, 4912 }),
    new FinancialTransaction(35, new List<decimal> { 3590, 4859 }, new List<decimal> { 8450 }),
    new FinancialTransaction(36, new List<decimal> { 305, 594, 391 }, new List<decimal> { 1221, 68 }),
    new FinancialTransaction(37, new List<decimal> { 2476, 4509, 65 }, new List<decimal> { 435, 255, 6359 }),
    new FinancialTransaction(38, new List<decimal> { 873, 734 }, new List<decimal> { 46, 1561 }),
    new FinancialTransaction(39, new List<decimal> { 2139, 45 }, new List<decimal> { 2183 }),
    new FinancialTransaction(40, new List<decimal> { 813, 6489 }, new List<decimal> { 894, 1568, 4839 }),
    new FinancialTransaction(41, new List<decimal> { 8947, 651 }, new List<decimal> { 468, 9130 }),
    new FinancialTransaction(42, new List<decimal> { 6984, 4518, 145 }, new List<decimal> { 9846, 1656, 144 }),
};

foreach(var financialTransaction in financialTransactions)
{
    Console.WriteLine($"Financial Transaction {financialTransaction.Id}:");
    Console.WriteLine($"Debits: {string.Join(", ", financialTransaction.Debits)}");
    Console.WriteLine($"Credits: {string.Join(", ", financialTransaction.Credits)}");
    Console.WriteLine();
}

public record FinancialTransaction(int Id, List<decimal> Debits, List<decimal> Credits);
