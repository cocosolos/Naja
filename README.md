# Naja



## LandSandBoat Database

Naja acts on an externally defined and managed database, so the best system I can come up with right now is to occasionally re-run the scaffolder and manage any changes (relationship data mostly) in a separate file implementing the same partial model class.

LSB database models are scaffolded into `Naja/Models/External/` using the following command in the root directory:

```
dotnet ef dbcontext scaffold "Server=localhost;Database=xidb;User=USER;Password=PASS;"  "Pomelo.EntityFrameworkCore.MySql" -p Naja -s Naja -o Models/External -c XidbContext --no-onconfiguring --no-build -f
```

Additional properties are defined in partial classes in `Naja/Models/`.


## Client Strings

Client strings are extracted using [ResourceExtractor](https://github.com/Windower/ResourceExtractor) and placed in the `Resources` directory.