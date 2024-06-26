# Naja *(pre-alpha)*

Naja interfaces with a [LandSandBoat](https://github.com/LandSandBoat/server) server database and allows for users and administrators to view and edit various different server objects. It is inspired by sites like [FFXIAH](https://ffxiah.com), [BG-Wiki](https://bg-wiki.com), and the FFXIV Mog Station, Online Store, and [The Lodestone](https://na.finalfantasyxiv.com/lodestone/), and aims to bring a similar experience to the LSB server emulator.

**Features include:**
- Live and historical Auction House listings.
- Item lookup and information. [^1]
- Online bazaar information.
- Account registration and log in.
- Character information display.
- Inventory management. [^2]
- Server Yell chat display.
- Yell chat moderation tools. [^3]

![AuctionHouse](https://github.com/cocosolos/Naja/assets/2593549/4ce4b9c9-541e-4240-af88-b63099d362de)

![Items_Details](https://github.com/cocosolos/Naja/assets/2593549/0e17e35f-526f-475e-9240-62df4b9012a3)

![Character_Select](https://github.com/cocosolos/Naja/assets/2593549/15a956ee-9f32-4356-936a-941c03674467)

![Yells_GM](https://github.com/cocosolos/Naja/assets/2593549/aa4fcb43-ecee-42a5-a9fe-bf05d91d7dd3)


**Future development goals:**
- Server status and news display.
- Online and offline character lists with filtering, including by current mission.
- A storefront for players to purchase in-game services and items using in-game currency.
- Battlefield records.
- Conquest/Besieged/Campaign/Colonization map information.
- Mob and NPC information.
- Auction and Delivery Box management.
- Linkshell chat and roster.
- Unity chat and information.
- AND MORE!


## LandSandBoat Database

Naja acts on an externally defined and managed database, so the best system I can come up with right now is to occasionally re-run the scaffolder and manage any changes (relationship data mostly) in a separate file implementing the same partial model class.

LSB database models are scaffolded into `Naja/Models/External/` using the following command in the root directory:

```
dotnet ef dbcontext scaffold "Server=localhost;Database=xidb;User=USER;Password=PASS;" "Pomelo.EntityFrameworkCore.MySql" -p Naja -s Naja -o Models/External -c XidbContext --no-onconfiguring --no-build -f
```

Additional properties are defined in partial classes in `Naja/Models/`.


## Client Strings

Client strings are extracted using [ResourceExtractor](https://github.com/Windower/ResourceExtractor) and placed in the `Resources` directory.


## LICENSE

MIT


[^1]: When possible and appropriate (such as equipment stats), item information is gathered directly from the LSB database, rather than relying on extracted client resources.
[^2]: Available only when selected character is offline.
[^3]: Available only when selected character is a GM.
