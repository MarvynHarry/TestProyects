export interface namedapiresourcelist<T> {
    name: string;
    count: number;
    next: string;
    previous: string;
    results: T[];
}