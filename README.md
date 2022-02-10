# Hardware
<img src="https://i.imgur.com/Ssb5kRJ.png" width="200">

```csharp

ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
ManagementObjectCollection managements = searcher.Get();
foreach (ManagementObject item in managements)
{
	PropertyDataCollection pd = item.Properties;
	ManagementPath mp = item.Path;
}
```