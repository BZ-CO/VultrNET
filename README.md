# VultrNET
Unofficial wrapper for Vultr API v2

![GitHub Workflow Status](https://img.shields.io/github/workflow/status/BZ-CO/VultrNET/.NET) ![GitHub](https://img.shields.io/github/license/BZ-CO/VultrNET) ![GitHub commit activity](https://img.shields.io/github/commit-activity/m/BZ-CO/VultrNET) ![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/BZ-CO/VultrNET)
---
#### Initializing client and getting account information
```csharp
var vultr = new VultrClient("your-vultr-api-key");
var account = await vultr.GetAccountInfoAsync();
```
#### Creating new bare metal instance
```csharp
var createBarMetal =
    await vultr.CreateBareMetalInstance(
        new CreateBareMetal("ams", "vbm-4c-32gb", appId: 3, label: "foo", enableIPv6: false));
```
