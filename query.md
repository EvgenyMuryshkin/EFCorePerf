# Main table query + incrementally adding more joins in each benchmark

## EF2
|                        Method | Idx |        Mean |     Error |      StdDev |      Median |
|------------------------------ |---- |------------:|----------:|------------:|------------:|
|  ShippingUnitsWithComposites0 |   0 |    425.1 us |   8.40 us |    11.49 us |    423.6 us |
|  ShippingUnitsWithComposites1 |   0 |  1,251.0 us |  24.69 us |    54.19 us |  1,244.2 us |
|  ShippingUnitsWithComposites2 |   0 |  1,290.5 us |  25.70 us |    50.73 us |  1,272.9 us |
|  ShippingUnitsWithComposites3 |   0 |    750.7 us |  14.56 us |    23.92 us |    749.3 us |
|  ShippingUnitsWithComposites4 |   0 |  1,172.4 us |  23.32 us |    36.31 us |  1,157.7 us |
|  ShippingUnitsWithComposites5 |   0 |  1,788.7 us |  39.74 us |   112.74 us |  1,758.2 us |
|  ShippingUnitsWithComposites6 |   0 |  1,542.6 us |  29.99 us |    42.05 us |  1,536.2 us |
|  ShippingUnitsWithComposites7 |   0 |  1,697.9 us |  33.91 us |    91.10 us |  1,662.2 us |
|  ShippingUnitsWithComposites8 |   0 |  1,983.5 us |  35.38 us |    31.36 us |  1,982.0 us |
|  ShippingUnitsWithComposites9 |   0 |  3,825.5 us | 232.09 us |   662.15 us |  3,751.7 us |
| ShippingUnitsWithComposites10 |   0 |  1,686.1 us |  33.26 us |    31.11 us |  1,680.2 us |
| ShippingUnitsWithComposites11 |   0 |  3,419.2 us | 193.59 us |   555.46 us |  3,188.9 us |
| ShippingUnitsWithComposites12 |   0 |  4,077.3 us | 245.78 us |   709.12 us |  3,871.1 us |
| ShippingUnitsWithComposites13 |   0 |  3,553.3 us | 189.82 us |   544.64 us |  3,359.5 us |
| ShippingUnitsWithComposites14 |   0 |  3,159.9 us | 168.68 us |   470.21 us |  3,048.4 us |
| ShippingUnitsWithComposites15 |   0 |  2,994.8 us | 175.41 us |   494.75 us |  2,821.8 us |
| ShippingUnitsWithComposites16 |   0 |  4,901.3 us | 213.03 us |   611.22 us |  4,863.2 us |
| ShippingUnitsWithComposites17 |   0 |  5,365.5 us | 429.63 us | 1,253.26 us |  5,069.8 us |
| ShippingUnitsWithComposites18 |   0 |  5,087.3 us | 275.01 us |   775.67 us |  4,996.1 us |
| ShippingUnitsWithComposites19 |   0 |  4,758.8 us | 266.14 us |   759.32 us |  4,593.5 us |
| ShippingUnitsWithComposites20 |   0 |  5,099.2 us | 276.60 us |   802.46 us |  4,940.2 us |
| ShippingUnitsWithComposites21 |   0 |  6,771.6 us | 427.45 us | 1,219.53 us |  6,661.9 us |
| ShippingUnitsWithComposites22 |   0 |  5,658.2 us | 343.25 us |   990.37 us |  5,490.9 us |
| ShippingUnitsWithComposites23 |   0 |  6,567.0 us | 347.07 us | 1,006.91 us |  6,415.5 us |
| ShippingUnitsWithComposites24 |   0 |  6,309.1 us | 337.87 us |   958.48 us |  6,282.4 us |
| ShippingUnitsWithComposites25 |   0 |  5,665.5 us | 352.02 us | 1,015.65 us |  5,383.9 us |
| ShippingUnitsWithComposites26 |   0 |  5,692.3 us | 348.85 us | 1,012.07 us |  5,521.4 us |
| ShippingUnitsWithComposites27 |   0 |  7,034.5 us | 291.54 us |   841.15 us |  6,987.8 us |
| ShippingUnitsWithComposites28 |   0 |  6,724.1 us | 265.19 us |   760.88 us |  6,622.0 us |
| ShippingUnitsWithComposites29 |   0 |  6,400.7 us | 386.40 us | 1,114.86 us |  6,305.3 us |
| ShippingUnitsWithComposites30 |   0 |  5,952.2 us | 517.16 us | 1,500.37 us |  5,428.2 us |
| ShippingUnitsWithComposites31 |   0 |  7,462.0 us | 358.58 us | 1,028.83 us |  7,304.5 us |
| ShippingUnitsWithComposites32 |   0 |  7,373.0 us | 203.50 us |   570.64 us |  7,347.6 us |
| ShippingUnitsWithComposites33 |   0 |  8,784.3 us | 139.26 us |   123.45 us |  8,817.1 us |
| ShippingUnitsWithComposites34 |   0 |  7,907.5 us | 120.78 us |   198.45 us |  7,838.5 us |
| ShippingUnitsWithComposites35 |   0 | 12,288.7 us | 418.00 us | 1,199.31 us | 12,173.6 us |
| ShippingUnitsWithComposites36 |   0 |  8,800.5 us | 144.59 us |   128.17 us |  8,752.0 us |
| ShippingUnitsWithComposites37 |   0 | 12,531.4 us | 383.77 us | 1,107.27 us | 12,098.1 us |
| ShippingUnitsWithComposites38 |   0 |  7,590.1 us | 151.34 us |   368.39 us |  7,443.6 us |
| ShippingUnitsWithComposites39 |   0 | 11,249.2 us | 181.78 us |   161.14 us | 11,206.0 us |
| ShippingUnitsWithComposites40 |   0 | 11,690.5 us | 405.02 us | 1,187.86 us | 11,579.7 us |
| ShippingUnitsWithComposites41 |   0 |  9,819.2 us | 151.21 us |   148.51 us |  9,765.6 us |
| ShippingUnitsWithComposites42 |   0 | 11,148.5 us | 161.87 us |   261.39 us | 11,047.2 us |
| ShippingUnitsWithComposites43 |   0 |  9,017.1 us | 180.27 us |   192.89 us |  8,952.2 us |
| ShippingUnitsWithComposites44 |   0 | 10,214.4 us | 200.09 us |   205.48 us | 10,168.3 us |
| ShippingUnitsWithComposites45 |   0 | 10,702.0 us | 206.28 us |   211.83 us | 10,631.3 us |
| ShippingUnitsWithComposites46 |   0 |  6,611.7 us | 127.53 us |   136.46 us |  6,583.2 us |
| ShippingUnitsWithComposites47 |   0 | 11,379.5 us | 431.47 us | 1,237.97 us | 11,525.4 us |
| ShippingUnitsWithComposites48 |   0 | 10,755.0 us | 103.89 us |    86.75 us | 10,749.9 us |
| ShippingUnitsWithComposites49 |   0 | 11,912.9 us | 186.40 us |   174.36 us | 11,918.2 us |
| ShippingUnitsWithComposites50 |   0 | 13,876.2 us | 217.28 us |   192.61 us | 13,822.6 us |
| ShippingUnitsWithComposites51 |   0 |  9,333.8 us | 185.03 us |   328.89 us |  9,181.4 us |
| ShippingUnitsWithComposites52 |   0 | 12,798.2 us | 227.18 us |   212.50 us | 12,744.1 us |
| ShippingUnitsWithComposites53 |   0 | 11,097.4 us | 198.56 us |   251.12 us | 11,004.8 us |
| ShippingUnitsWithComposites54 |   0 | 15,158.2 us | 160.34 us |   142.14 us | 15,157.1 us |
| ShippingUnitsWithComposites55 |   0 | 15,737.7 us | 280.43 us |   411.05 us | 15,590.8 us |
| ShippingUnitsWithComposites56 |   0 | 12,225.6 us | 445.86 us | 1,293.52 us | 12,300.8 us |
| ShippingUnitsWithComposites57 |   0 | 10,192.3 us | 175.47 us |   155.55 us | 10,128.6 us |
| ShippingUnitsWithComposites58 |   0 |  9,145.6 us | 179.46 us |   206.67 us |  9,085.0 us |
| ShippingUnitsWithComposites59 |   0 | 12,042.9 us | 466.93 us | 1,354.64 us | 11,920.5 us |
| ShippingUnitsWithComposites60 |   0 | 10,221.2 us | 193.19 us |   180.71 us | 10,177.8 us |
| ShippingUnitsWithComposites61 |   0 | 16,421.6 us | 327.67 us |   907.97 us | 16,069.8 us |


## EF6 - Single Query

|                        Method | Idx |        Mean |       Error |      StdDev |      Median |
|------------------------------ |---- |------------:|------------:|------------:|------------:|
|  ShippingUnitsWithComposites0 |   0 |    597.2 us |     7.58 us |     9.02 us |    595.2 us |
|  ShippingUnitsWithComposites1 |   0 |  1,125.9 us |    22.36 us |    51.38 us |  1,109.0 us |
|  ShippingUnitsWithComposites2 |   0 |  1,359.6 us |    26.48 us |    28.34 us |  1,348.1 us |
|  ShippingUnitsWithComposites3 |   0 |  1,052.0 us |    19.78 us |    44.66 us |  1,035.3 us |
|  ShippingUnitsWithComposites4 |   0 |  1,236.8 us |    17.20 us |    14.36 us |  1,238.1 us |
|  ShippingUnitsWithComposites5 |   0 |  1,499.5 us |    28.97 us |    72.13 us |  1,468.7 us |
|  ShippingUnitsWithComposites6 |   0 |  1,363.8 us |    22.85 us |    19.08 us |  1,364.1 us |
|  ShippingUnitsWithComposites7 |   0 |  1,626.9 us |    29.15 us |    24.34 us |  1,620.7 us |
|  ShippingUnitsWithComposites8 |   0 |  1,785.1 us |    34.17 us |    43.21 us |  1,788.7 us |
|  ShippingUnitsWithComposites9 |   0 |  2,466.1 us |   137.99 us |   393.70 us |  2,327.8 us |
| ShippingUnitsWithComposites10 |   0 |  3,121.1 us |   168.93 us |   487.40 us |  2,966.4 us |
| ShippingUnitsWithComposites11 |   0 |  2,751.2 us |   215.88 us |   619.41 us |  2,617.8 us |
| ShippingUnitsWithComposites12 |   0 |  3,094.4 us |   248.40 us |   708.70 us |  2,873.2 us |
| ShippingUnitsWithComposites13 |   0 |  2,440.9 us |   123.99 us |   349.72 us |  2,361.7 us |
| ShippingUnitsWithComposites14 |   0 |  2,709.5 us |   144.50 us |   416.91 us |  2,599.8 us |
| ShippingUnitsWithComposites15 |   0 |  2,976.6 us |   173.27 us |   505.44 us |  2,928.1 us |
| ShippingUnitsWithComposites16 |   0 |  3,251.9 us |   166.14 us |   476.69 us |  3,098.3 us |
| ShippingUnitsWithComposites17 |   0 |  3,163.4 us |   241.64 us |   701.03 us |  3,082.1 us |
| ShippingUnitsWithComposites18 |   0 |  3,714.8 us |   243.42 us |   702.31 us |  3,656.2 us |
| ShippingUnitsWithComposites19 |   0 |  3,357.6 us |   202.27 us |   583.59 us |  3,277.4 us |
| ShippingUnitsWithComposites20 |   0 |  3,236.2 us |   192.85 us |   559.50 us |  3,252.0 us |
| ShippingUnitsWithComposites21 |   0 |  3,990.8 us |   192.30 us |   557.91 us |  3,908.1 us |
| ShippingUnitsWithComposites22 |   0 |  3,494.7 us |   225.77 us |   640.48 us |  3,388.3 us |
| ShippingUnitsWithComposites23 |   0 |  3,763.1 us |   190.61 us |   537.61 us |  3,820.5 us |
| ShippingUnitsWithComposites24 |   0 |  4,018.1 us |   197.87 us |   564.53 us |  3,991.3 us |
| ShippingUnitsWithComposites25 |   0 |  4,460.5 us |   278.56 us |   808.15 us |  4,400.9 us |
| ShippingUnitsWithComposites26 |   0 |  4,318.0 us |   269.14 us |   780.82 us |  4,210.8 us |
| ShippingUnitsWithComposites27 |   0 |  3,444.1 us |   177.57 us |   515.16 us |  3,378.0 us |
| ShippingUnitsWithComposites28 |   0 |  4,269.7 us |   270.28 us |   779.81 us |  4,163.7 us |
| ShippingUnitsWithComposites29 |   0 |  5,180.6 us |   384.26 us | 1,120.90 us |  4,991.5 us |
| ShippingUnitsWithComposites30 |   0 |  2,750.8 us |   137.86 us |   388.82 us |  2,658.6 us |
| ShippingUnitsWithComposites31 |   0 |  3,807.8 us |   207.81 us |   599.59 us |  3,688.5 us |
| ShippingUnitsWithComposites32 |   0 |  3,398.6 us |   171.04 us |   482.42 us |  3,284.7 us |
| ShippingUnitsWithComposites33 |   0 |  7,024.4 us |   119.14 us |   105.61 us |  7,036.3 us |
| ShippingUnitsWithComposites34 |   0 |  5,813.6 us |   115.03 us |   107.60 us |  5,772.3 us |
| ShippingUnitsWithComposites35 |   0 |  6,150.2 us |   101.49 us |    94.93 us |  6,127.0 us |
| ShippingUnitsWithComposites36 |   0 | 10,908.1 us |   570.85 us | 1,665.19 us | 10,794.1 us |
| ShippingUnitsWithComposites37 |   0 |  8,498.5 us |   164.90 us |   231.17 us |  8,439.4 us |
| ShippingUnitsWithComposites38 |   0 |  6,289.6 us |   365.58 us | 1,037.09 us |  6,079.5 us |
| ShippingUnitsWithComposites39 |   0 |  7,209.6 us |   137.04 us |   343.79 us |  7,141.2 us |
| ShippingUnitsWithComposites40 |   0 |  7,103.0 us |   126.85 us |   177.83 us |  7,067.3 us |
| ShippingUnitsWithComposites41 |   0 | 14,060.9 us |   619.03 us | 1,815.49 us | 13,904.7 us |
| ShippingUnitsWithComposites42 |   0 |  7,382.4 us |   101.81 us |    85.01 us |  7,380.9 us |
| ShippingUnitsWithComposites43 |   0 |  7,077.5 us |   138.13 us |   159.07 us |  7,018.9 us |
| ShippingUnitsWithComposites44 |   0 |  9,699.5 us |   186.01 us |   191.02 us |  9,656.1 us |
| ShippingUnitsWithComposites45 |   0 |  7,397.5 us |   133.84 us |   111.77 us |  7,410.8 us |
| ShippingUnitsWithComposites46 |   0 |  6,250.5 us |   104.02 us |   115.62 us |  6,226.1 us |
| ShippingUnitsWithComposites47 |   0 |  8,666.1 us |   164.66 us |   137.50 us |  8,635.3 us |
| ShippingUnitsWithComposites48 |   0 | 26,833.0 us |   407.34 us |   361.09 us | 26,738.7 us |
| ShippingUnitsWithComposites49 |   0 | 29,438.2 us |   587.95 us | 1,619.39 us | 29,413.9 us |
| ShippingUnitsWithComposites50 |   0 | 26,379.6 us |   356.18 us |   333.17 us | 26,312.6 us |
| ShippingUnitsWithComposites51 |   0 | 29,074.8 us |   432.18 us |   383.11 us | 28,978.3 us |
| ShippingUnitsWithComposites52 |   0 | 30,292.6 us |   427.42 us |   399.81 us | 30,065.4 us |
| ShippingUnitsWithComposites53 |   0 | 36,942.6 us |   626.69 us |   769.63 us | 36,757.2 us |
| ShippingUnitsWithComposites54 |   0 | 44,940.7 us |   889.63 us | 1,735.15 us | 45,325.9 us |
| ShippingUnitsWithComposites55 |   0 | 48,249.0 us |   943.11 us | 1,839.47 us | 48,116.8 us |
| ShippingUnitsWithComposites56 |   0 | 50,341.4 us | 1,020.86 us | 2,929.05 us | 49,806.8 us |
| ShippingUnitsWithComposites57 |   0 | 46,197.0 us |   896.14 us | 1,256.26 us | 45,939.6 us |
| ShippingUnitsWithComposites58 |   0 | 45,138.6 us |   889.05 us | 1,460.74 us | 44,485.1 us |
| ShippingUnitsWithComposites59 |   0 | 54,414.8 us | 1,076.61 us | 2,473.70 us | 53,827.7 us |
| ShippingUnitsWithComposites60 |   0 | 50,471.6 us | 1,003.13 us | 1,304.35 us | 49,864.2 us |
| ShippingUnitsWithComposites61 |   0 | 52,216.9 us |   851.93 us |   755.22 us | 51,955.0 us |

#EF6 - split query
|                                    Method | Idx |         Mean |       Error |       StdDev |       Median |
|------------------------------------------ |---- |-------------:|------------:|-------------:|-------------:|
|  ShippingUnitsWithComposites0AsSplitQuery |   0 |     536.1 us |     6.08 us |      5.39 us |     534.9 us |
|  ShippingUnitsWithComposites1AsSplitQuery |   0 |     930.3 us |    15.57 us |     14.57 us |     930.5 us |
|  ShippingUnitsWithComposites2AsSplitQuery |   0 |     818.1 us |     9.67 us |      8.08 us |     817.2 us |
|  ShippingUnitsWithComposites3AsSplitQuery |   0 |     930.4 us |     9.64 us |      9.02 us |     927.7 us |
|  ShippingUnitsWithComposites4AsSplitQuery |   0 |   1,473.9 us |    26.70 us |     36.54 us |   1,454.7 us |
|  ShippingUnitsWithComposites5AsSplitQuery |   0 |   1,390.8 us |    22.96 us |     22.55 us |   1,380.4 us |
|  ShippingUnitsWithComposites6AsSplitQuery |   0 |   1,705.2 us |    31.72 us |     50.32 us |   1,685.4 us |
|  ShippingUnitsWithComposites7AsSplitQuery |   0 |   1,356.0 us |    26.94 us |     35.04 us |   1,337.8 us |
|  ShippingUnitsWithComposites8AsSplitQuery |   0 |   1,867.3 us |    35.20 us |     54.80 us |   1,850.6 us |
|  ShippingUnitsWithComposites9AsSplitQuery |   0 |   3,047.1 us |   132.75 us |    389.32 us |   2,930.5 us |
| ShippingUnitsWithComposites10AsSplitQuery |   0 |   3,726.2 us |   172.51 us |    492.19 us |   3,605.2 us |
| ShippingUnitsWithComposites11AsSplitQuery |   0 |   3,608.3 us |   176.58 us |    515.09 us |   3,420.2 us |
| ShippingUnitsWithComposites12AsSplitQuery |   0 |   4,283.9 us |   147.05 us |    424.28 us |   4,298.9 us |
| ShippingUnitsWithComposites13AsSplitQuery |   0 |   3,300.9 us |   133.71 us |    390.03 us |   3,227.6 us |
| ShippingUnitsWithComposites14AsSplitQuery |   0 |   3,541.8 us |   132.79 us |    389.45 us |   3,404.2 us |
| ShippingUnitsWithComposites15AsSplitQuery |   0 |   4,193.6 us |   114.69 us |    329.07 us |   4,132.0 us |
| ShippingUnitsWithComposites16AsSplitQuery |   0 |   4,148.8 us |   186.15 us |    537.08 us |   4,108.1 us |
| ShippingUnitsWithComposites17AsSplitQuery |   0 |   4,826.1 us |   259.53 us |    752.95 us |   4,695.4 us |
| ShippingUnitsWithComposites18AsSplitQuery |   0 |   5,078.1 us |   229.98 us |    663.54 us |   5,032.1 us |
| ShippingUnitsWithComposites19AsSplitQuery |   0 |   3,787.2 us |   135.73 us |    391.62 us |   3,791.9 us |
| ShippingUnitsWithComposites20AsSplitQuery |   0 |   3,636.1 us |   161.24 us |    470.33 us |   3,494.9 us |
| ShippingUnitsWithComposites21AsSplitQuery |   0 |   4,627.1 us |   195.75 us |    567.90 us |   4,559.0 us |
| ShippingUnitsWithComposites22AsSplitQuery |   0 |   5,476.6 us |   222.73 us |    639.06 us |   5,411.7 us |
| ShippingUnitsWithComposites23AsSplitQuery |   0 |   5,662.3 us |   311.32 us |    913.04 us |   5,577.6 us |
| ShippingUnitsWithComposites24AsSplitQuery |   0 |   5,324.3 us |   183.69 us |    529.97 us |   5,264.6 us |
| ShippingUnitsWithComposites25AsSplitQuery |   0 |   3,466.4 us |    54.18 us |     66.54 us |   3,451.5 us |
| ShippingUnitsWithComposites26AsSplitQuery |   0 |   5,355.1 us |   302.17 us |    871.84 us |   5,178.6 us |
| ShippingUnitsWithComposites27AsSplitQuery |   0 |   4,880.0 us |   239.90 us |    695.99 us |   4,874.6 us |
| ShippingUnitsWithComposites28AsSplitQuery |   0 |   6,137.8 us |   266.29 us |    776.77 us |   6,086.6 us |
| ShippingUnitsWithComposites29AsSplitQuery |   0 |   5,643.2 us |   234.88 us |    681.42 us |   5,483.4 us |
| ShippingUnitsWithComposites30AsSplitQuery |   0 |   6,770.5 us |   251.82 us |    742.50 us |   6,696.9 us |
| ShippingUnitsWithComposites31AsSplitQuery |   0 |   6,834.8 us |   281.65 us |    826.02 us |   6,742.9 us |
| ShippingUnitsWithComposites32AsSplitQuery |   0 |  40,420.9 us |   135.90 us |    113.48 us |  40,427.3 us |
| ShippingUnitsWithComposites33AsSplitQuery |   0 |  41,043.9 us | 1,401.15 us |  3,997.57 us |  40,543.1 us |
| ShippingUnitsWithComposites34AsSplitQuery |   0 |  41,651.6 us | 1,797.82 us |  5,100.13 us |  40,491.8 us |
| ShippingUnitsWithComposites35AsSplitQuery |   0 |  46,609.1 us | 3,029.24 us |  8,788.38 us |  43,206.5 us |
| ShippingUnitsWithComposites36AsSplitQuery |   0 |  41,981.6 us | 2,021.99 us |  5,833.89 us |  41,167.9 us |
| ShippingUnitsWithComposites37AsSplitQuery |   0 |  47,407.1 us |   690.06 us |    645.49 us |  47,323.8 us |
| ShippingUnitsWithComposites38AsSplitQuery |   0 |  53,412.9 us | 2,672.71 us |  7,796.41 us |  51,440.4 us |
| ShippingUnitsWithComposites39AsSplitQuery |   0 |  55,746.0 us | 2,189.78 us |  6,282.88 us |  53,119.3 us |
| ShippingUnitsWithComposites40AsSplitQuery |   0 |  66,301.2 us | 1,957.01 us |  5,646.43 us |  65,514.1 us |
| ShippingUnitsWithComposites41AsSplitQuery |   0 |  77,695.2 us | 2,318.52 us |  6,726.45 us |  76,804.6 us |
| ShippingUnitsWithComposites42AsSplitQuery |   0 |  65,822.9 us | 1,310.90 us |  3,718.81 us |  65,418.4 us |
| ShippingUnitsWithComposites43AsSplitQuery |   0 |  74,544.8 us | 1,569.44 us |  4,578.12 us |  74,040.6 us |
| ShippingUnitsWithComposites44AsSplitQuery |   0 |  78,822.9 us | 1,953.85 us |  5,668.48 us |  77,890.7 us |
| ShippingUnitsWithComposites45AsSplitQuery |   0 |  80,269.5 us | 2,140.86 us |  6,176.86 us |  80,308.1 us |
| ShippingUnitsWithComposites46AsSplitQuery |   0 |  80,898.8 us | 1,859.02 us |  5,393.37 us |  80,092.8 us |
| ShippingUnitsWithComposites47AsSplitQuery |   0 |  82,082.6 us | 1,724.10 us |  4,974.42 us |  81,437.6 us |
| ShippingUnitsWithComposites48AsSplitQuery |   0 |  85,541.6 us | 1,830.00 us |  5,309.18 us |  84,763.7 us |
| ShippingUnitsWithComposites49AsSplitQuery |   0 |  85,166.2 us | 1,685.58 us |  4,499.16 us |  84,536.8 us |
| ShippingUnitsWithComposites50AsSplitQuery |   0 | 141,404.6 us | 2,613.55 us |  6,057.29 us | 141,883.5 us |
| ShippingUnitsWithComposites51AsSplitQuery |   0 | 233,612.8 us | 4,500.75 us |  6,454.83 us | 231,275.9 us |
| ShippingUnitsWithComposites52AsSplitQuery |   0 | 233,837.5 us | 4,568.71 us |  7,633.28 us | 232,581.5 us |
| ShippingUnitsWithComposites53AsSplitQuery |   0 | 247,752.0 us | 4,745.84 us | 12,502.45 us | 246,607.9 us |
| ShippingUnitsWithComposites54AsSplitQuery |   0 | 260,719.2 us | 5,187.60 us |  8,808.94 us | 261,965.6 us |
| ShippingUnitsWithComposites55AsSplitQuery |   0 | 258,694.8 us | 5,075.31 us |  9,532.66 us | 259,937.9 us |
| ShippingUnitsWithComposites56AsSplitQuery |   0 | 260,965.5 us | 4,733.64 us |  7,908.86 us | 259,916.1 us |
| ShippingUnitsWithComposites57AsSplitQuery |   0 | 250,275.5 us | 4,936.56 us |  9,744.28 us | 251,802.1 us |
| ShippingUnitsWithComposites58AsSplitQuery |   0 | 257,142.5 us | 5,028.23 us |  6,175.12 us | 258,554.1 us |
| ShippingUnitsWithComposites59AsSplitQuery |   0 | 271,008.4 us | 5,416.59 us |  8,432.98 us | 272,582.7 us |
| ShippingUnitsWithComposites60AsSplitQuery |   0 | 263,155.9 us | 4,995.39 us |  9,007.71 us | 262,762.0 us |
| ShippingUnitsWithComposites61AsSplitQuery |   0 | 274,869.6 us | 5,453.54 us |  8,960.32 us | 273,003.3 us |

# Main table query + 1 additional joins

## EF2
|                    Method | Idx |       Mean |    Error |   StdDev |     Median |
|-------------------------- |---- |-----------:|---------:|---------:|-----------:|
|  ShippingUnitsTopPlusOne0 |   0 |   894.8 us |  7.83 us |  6.54 us |   892.9 us |
|  ShippingUnitsTopPlusOne1 |   0 | 1,153.9 us | 16.30 us | 12.73 us | 1,151.5 us |
|  ShippingUnitsTopPlusOne2 |   0 |   853.9 us | 11.93 us | 10.58 us |   851.1 us |
|  ShippingUnitsTopPlusOne3 |   0 |   887.1 us |  5.36 us |  4.47 us |   887.1 us |
|  ShippingUnitsTopPlusOne4 |   0 |   606.4 us |  4.81 us |  3.75 us |   604.9 us |
|  ShippingUnitsTopPlusOne5 |   0 |   800.5 us | 11.31 us | 10.03 us |   797.3 us |
|  ShippingUnitsTopPlusOne6 |   0 |   640.0 us | 11.14 us | 18.00 us |   631.3 us |
|  ShippingUnitsTopPlusOne7 |   0 |   761.4 us | 10.86 us |  9.07 us |   758.5 us |
|  ShippingUnitsTopPlusOne8 |   0 |   660.8 us |  2.44 us |  2.16 us |   660.1 us |
|  ShippingUnitsTopPlusOne9 |   0 |   587.5 us |  1.92 us |  1.80 us |   587.8 us |
| ShippingUnitsTopPlusOne10 |   0 |   596.9 us | 12.16 us | 34.50 us |   610.9 us |
| ShippingUnitsTopPlusOne11 |   0 | 2,870.7 us | 45.92 us | 79.20 us | 2,849.2 us |
| ShippingUnitsTopPlusOne12 |   0 | 2,534.7 us | 10.99 us | 10.28 us | 2,535.7 us |
| ShippingUnitsTopPlusOne13 |   0 | 2,158.4 us | 41.64 us | 47.95 us | 2,145.3 us |
| ShippingUnitsTopPlusOne14 |   0 | 2,226.2 us | 13.50 us | 12.63 us | 2,226.1 us |
| ShippingUnitsTopPlusOne15 |   0 | 3,377.9 us | 18.69 us | 15.61 us | 3,381.7 us |
| ShippingUnitsTopPlusOne16 |   0 |   954.3 us | 18.42 us | 21.22 us |   962.2 us |
| ShippingUnitsTopPlusOne17 |   0 |   964.7 us | 19.25 us | 29.40 us |   950.7 us |
| ShippingUnitsTopPlusOne18 |   0 |   687.0 us |  2.52 us |  2.11 us |   687.0 us |
| ShippingUnitsTopPlusOne19 |   0 | 1,107.3 us |  3.56 us |  3.16 us | 1,107.9 us |
| ShippingUnitsTopPlusOne20 |   0 | 1,278.0 us | 20.57 us | 24.49 us | 1,281.0 us |
| ShippingUnitsTopPlusOne21 |   0 |   373.1 us |  2.46 us |  2.05 us |   373.2 us |

## EF6

|                    Method | Idx |       Mean |     Error |    StdDev |     Median |
|-------------------------- |---- |-----------:|----------:|----------:|-----------:|
|  ShippingUnitsTopPlusOne0 |   0 |   856.6 us |  16.99 us |  42.93 us |   850.0 us |
|  ShippingUnitsTopPlusOne1 |   0 | 1,021.3 us |  19.63 us |  18.37 us | 1,020.5 us |
|  ShippingUnitsTopPlusOne2 |   0 | 1,082.1 us |   7.26 us |   6.79 us | 1,081.2 us |
|  ShippingUnitsTopPlusOne3 |   0 |   915.2 us |   6.32 us |   4.93 us |   915.0 us |
|  ShippingUnitsTopPlusOne4 |   0 | 1,043.4 us |   5.90 us |   4.93 us | 1,044.8 us |
|  ShippingUnitsTopPlusOne5 |   0 |   590.3 us |  11.72 us |  16.05 us |   583.0 us |
|  ShippingUnitsTopPlusOne6 |   0 |   682.8 us |   3.97 us |   3.71 us |   683.1 us |
|  ShippingUnitsTopPlusOne7 |   0 |   795.3 us |   8.69 us |   7.70 us |   793.1 us |
|  ShippingUnitsTopPlusOne8 |   0 |   620.0 us |   3.47 us |   2.71 us |   619.2 us |
|  ShippingUnitsTopPlusOne9 |   0 |   574.0 us |   2.95 us |   2.75 us |   573.4 us |
| ShippingUnitsTopPlusOne10 |   0 |   530.4 us |   5.89 us |   5.22 us |   530.1 us |
| ShippingUnitsTopPlusOne11 |   0 | 2,032.3 us |  11.14 us |  10.42 us | 2,031.1 us |
| ShippingUnitsTopPlusOne12 |   0 | 5,327.0 us |  96.09 us |  80.24 us | 5,328.2 us |
| ShippingUnitsTopPlusOne13 |   0 | 2,044.4 us |  22.36 us |  20.91 us | 2,040.6 us |
| ShippingUnitsTopPlusOne14 |   0 | 1,545.4 us |  10.94 us |   9.70 us | 1,547.5 us |
| ShippingUnitsTopPlusOne15 |   0 | 2,856.2 us |  94.73 us | 276.33 us | 2,745.4 us |
| ShippingUnitsTopPlusOne16 |   0 |   911.0 us |   8.42 us |   7.46 us |   912.5 us |
| ShippingUnitsTopPlusOne17 |   0 | 1,232.7 us |  23.56 us |  22.04 us | 1,228.5 us |
| ShippingUnitsTopPlusOne18 |   0 |   972.4 us |   8.53 us |   7.98 us |   971.6 us |
| ShippingUnitsTopPlusOne19 |   0 | 1,148.5 us |  13.44 us |  12.57 us | 1,149.1 us |
| ShippingUnitsTopPlusOne20 |   0 | 1,022.7 us |  20.11 us |  28.20 us | 1,010.0 us |
| ShippingUnitsTopPlusOne21 |   0 |   446.2 us |   3.84 us |   3.59 us |   446.0 us |

## EF6 SplitQuery
|                                Method | Idx |       Mean |     Error |    StdDev |     Median |
|-------------------------------------- |---- |-----------:|----------:|----------:|-----------:|
|  ShippingUnitsTopPlusOne0AsSplitQuery |   0 | 1,169.4 us |  21.32 us |  18.90 us | 1,168.8 us |
|  ShippingUnitsTopPlusOne1AsSplitQuery |   0 | 1,653.5 us |  32.76 us |  61.53 us | 1,620.2 us |
|  ShippingUnitsTopPlusOne2AsSplitQuery |   0 | 1,420.4 us |   9.17 us |   8.13 us | 1,419.0 us |
|  ShippingUnitsTopPlusOne3AsSplitQuery |   0 |   899.9 us |  13.89 us |  12.99 us |   901.6 us |
|  ShippingUnitsTopPlusOne4AsSplitQuery |   0 |   898.7 us |  12.99 us |  10.85 us |   895.2 us |
|  ShippingUnitsTopPlusOne5AsSplitQuery |   0 |   626.0 us |   9.21 us |   8.17 us |   628.2 us |
|  ShippingUnitsTopPlusOne6AsSplitQuery |   0 |   565.8 us |   9.34 us |   7.80 us |   565.8 us |
|  ShippingUnitsTopPlusOne7AsSplitQuery |   0 |   823.9 us |   4.17 us |   3.48 us |   823.2 us |
|  ShippingUnitsTopPlusOne8AsSplitQuery |   0 | 1,114.2 us |   9.17 us |   7.66 us | 1,112.8 us |
|  ShippingUnitsTopPlusOne9AsSplitQuery |   0 |   592.2 us |   8.57 us |   7.16 us |   591.8 us |
| ShippingUnitsTopPlusOne10AsSplitQuery |   0 |   582.7 us |   2.97 us |   2.63 us |   582.7 us |
| ShippingUnitsTopPlusOne11AsSplitQuery |   0 | 1,742.2 us |  15.56 us |  12.15 us | 1,739.3 us |
| ShippingUnitsTopPlusOne12AsSplitQuery |   0 | 3,271.1 us | 132.59 us | 384.67 us | 3,301.7 us |
| ShippingUnitsTopPlusOne13AsSplitQuery |   0 | 4,408.8 us | 218.26 us | 633.21 us | 4,307.6 us |
| ShippingUnitsTopPlusOne14AsSplitQuery |   0 | 1,817.8 us |  11.74 us |   9.16 us | 1,821.8 us |
| ShippingUnitsTopPlusOne15AsSplitQuery |   0 | 2,318.9 us |  28.19 us |  24.99 us | 2,314.9 us |
| ShippingUnitsTopPlusOne16AsSplitQuery |   0 |   957.1 us |  19.10 us |  32.43 us |   960.0 us |
| ShippingUnitsTopPlusOne17AsSplitQuery |   0 | 1,080.2 us |   5.49 us |   4.87 us | 1,080.1 us |
| ShippingUnitsTopPlusOne18AsSplitQuery |   0 | 1,434.8 us |  14.11 us |  15.10 us | 1,432.3 us |
| ShippingUnitsTopPlusOne19AsSplitQuery |   0 |   913.8 us |   8.31 us |   7.77 us |   913.3 us |
| ShippingUnitsTopPlusOne20AsSplitQuery |   0 | 1,087.8 us |  16.20 us |  14.36 us | 1,082.8 us |
| ShippingUnitsTopPlusOne21AsSplitQuery |   0 |   408.3 us |   0.83 us |   0.70 us |   408.3 us |


# Distilled 

## EF2

|    Method | Idx |     Mean |   Error |  StdDev |
|---------- |---- |---------:|--------:|--------:|
| Distilled |   0 | 244.2 ms | 4.70 ms | 5.60 ms |

|    Method | Idx |     Mean |   Error |  StdDev |
|---------- |---- |---------:|--------:|--------:|
| Distilled |   0 | 274.8 ms | 5.40 ms | 9.46 ms |

## EF6
|                 Method | Idx |     Mean |   Error |  StdDev |   Median |
|----------------------- |---- |---------:|--------:|--------:|---------:|
|              Distilled |   0 | 168.8 ms | 3.35 ms | 5.01 ms | 166.3 ms |
| Distilled_AsSplitQuery |   0 | 179.4 ms | 1.46 ms | 1.29 ms | 179.2 ms |