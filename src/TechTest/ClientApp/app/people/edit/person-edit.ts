import { autoinject } from 'aurelia-framework';
import { Router, RouteConfig } from 'aurelia-router'
import { HttpClient, json } from 'aurelia-fetch-client';
import { Person } from '../models/person';
import { IColour } from '../interfaces/icolour';
import { IPerson } from '../interfaces/iperson';

@autoinject
export class PersonEdit {

  constructor(private http: HttpClient, private router: Router) { }

  private heading: string;
  private person: Person;
  private colourOptions: IColour[] = [];
  private routerConfig: RouteConfig;
  selectedProductIds = [];
  async activate(params, routerConfig: RouteConfig) {
      this.routerConfig = routerConfig;
    
    const personResponse = await this.http.fetch(`/people/${params.id}`);
    this.personFetched(await personResponse.json());

    const colourResponse = await this.http.fetch('/colours');
    this.colourOptions = await colourResponse.json() as IColour[];
  }

  personFetched(person: IPerson): void {
    this.person = new Person(person)
    this.heading = `Update ${this.person.fullName}`;
    this.routerConfig.navModel.setTitle(`Update ${this.person.fullName}`);
  }

  colourMatcher(favouriteColour: IColour, checkBoxColour: IColour) {
    return favouriteColour.id === checkBoxColour.id;
  }

    async submit() {

        console.log(this.person)
           this.http.fetch(`/people?id=${this.person.id}`, {
               method: "PUT",
               body: JSON.stringify(this.person),
              headers: {
                  'Content-Type': 'application/json',
                   'Accept': 'application/json'
              }
           })

           .then(response => response.json())
            .then(data => {
                   console.log(data);
               });
        this.router.navigate('people');
    // TODO: Step 7
    //
    // Implement the submit and save logic.
    // Send a JSON request to the API with the newly updated
    // this.person object. If the response is successful then
    // the user should be navigated to the list page.

   
  }

  cancel() {
    this.router.navigate('people');
  }
}
