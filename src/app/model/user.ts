import { BodyComposition } from "./BodyComposition";
import { BodyMeasuremets } from "./BodyMeasuremets";

export interface User{

    id?: number;
    name?: string;
    bodyComposition?: BodyComposition;
    bodyMeasurements?: BodyMeasuremets;

}
