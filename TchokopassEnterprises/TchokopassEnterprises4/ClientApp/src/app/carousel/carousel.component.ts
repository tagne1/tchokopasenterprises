
import { Component, OnInit } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';

// Import the Image interface
import { Image } from './carousel.image.interface';

@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.css'],
  providers: [NgbCarouselConfig]  // add NgbCarouselConfig to the component providers

})
export class CarouselComponent implements OnInit {

  //images data to be bound to the template
  public images = IMAGES;

  constructor(config: NgbCarouselConfig) {
    // customize default values of carousels used by this component tree

    config.interval = 10000;
    config.wrap = false;
    config.keyboard = false;
    config.pauseOnHover = false;
  }

  ngOnInit() {
  }

}
//IMAGES array implementing Image interface
var IMAGES: Image[] = [
  { "title": "We1", "url": "../Images/Cashew Nuts/CashewImage0.jpg" },
  { "title": "Gen2", "url": "../Images/Cashew Nuts/CashewImage1.jpg" },
  { "title": "Po3", "url": "../Images/Cashew Nuts/CashewImage2.jpg" },
  { "title": "P4", "url": "../Images/Cashew Nuts/CashewImage3.jpg" },
  { "title": "We5 a", "url": "../Images/Cashew Nuts/CashewImage4.jpg" },
  { "title": "Gene6r", "url": "../Images/Cashew Nuts/CashewImage5.jpg" },
  { "title": "Pott7", "url": "../Images/Cashew Nuts/CashewImage6.jpg" },
  { "title": "Pre8-", "url": "../Images/Cashew Nuts/CashewImage7.jpg" },
  { "title": "P9", "url": "../Images/Cashew Nuts/CashewImage8.jpg" },
  { "title": "Pre-Scho10", "url": "../Images/Cashew Nuts/CashewImage9.jpg" },
  { "title": "Pre-Scho11", "url": "../Images/Cashew Nuts/CashewImage10.jpg" },
  { "title": "Pre-Scho12", "url": "../Images/Cashew Nuts/CashewImage11.jpg" },
  { "title": "Pre-Scho13", "url": "../Images/Cashew Nuts/CashewImage12.jpg" },
  { "title": "Pre-Scho14", "url": "../Images/Cashew Nuts/CashewImage13.jpg" },
  { "title": "Pre-Scho13", "url": "../Images/Cashew Nuts/CashewImage14.jpg" },
  { "title": "Pre-Scho14", "url": "../Images/Cashew Nuts/CashewImage15.jpg" }
];
