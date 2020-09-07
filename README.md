# What is PersonGenerator?

PersonGenerator can generate unique person with random name, age, birthday, email, etc.

# How do I use PersonGenerator?

```csharp
GeneratorSettings settings = new GeneratorSettings
{
    Language = Languages.English,
    FirstName = true,
    MiddleName = true,
    LastName = true
};

PersonGenerator.PersonGenerator personGenerator = new PersonGenerator.PersonGenerator(settings);
List<Person> people = personGenerator.Generate(5);
```

```csharp
GeneratorSettings settings = new GeneratorSettings
{
    Age = true,
    MinAge = minAge,
    MaxAge = maxAge
};

PersonGenerator.PersonGenerator personGenerator = new PersonGenerator.PersonGenerator(settings);
List<Person> people = personGenerator.Generate(100);
```
