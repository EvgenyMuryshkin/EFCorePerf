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


## EF6

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

# Main table query + 1 additional joins

coming soon