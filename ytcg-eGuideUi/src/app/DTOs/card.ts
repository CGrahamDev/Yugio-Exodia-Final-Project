export interface Card {
    id: number | null;
    name: string;
    type: string;
    frameType: string | null;
    description: string;
    atk: number;
    def: number; 
    level: number | null;
    race: string;
    attribute: string;
    imageUrl: string;
}
