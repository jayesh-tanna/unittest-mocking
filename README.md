
# unittest-mocking

This solution contains below components.

Contracts: All entities, enums will be part of this component.

Repositories: This component contains all Repositories including IRepository interface. All repositories implementing IRepository interface. This component is responsible to connect with Data component. 

Services: This component is responsible to contain all business logic.

Services.Interfaces: This component contains interfaces related to services. So service can implement respective interface. This can be used for DI.

Services.UnitTests: This components having all unit tests. This component contains unit tests related to our services. 


