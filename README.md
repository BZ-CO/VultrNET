# VultrNET
Unofficial wrapper for Vultr API v2

#### Initializing client and getting account information

```csharp
var vultr = new VultrClient("C3B2VM2IQ67WSJES62MCALB3EWOMG2YAGWYA");
var account = await vultr.GetAccountInfoAsync();
```