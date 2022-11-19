import { IProduct } from './product';

export interface Ipagination {
  pageIndex: number;
  pageSize: number;
  count: number;
  data: IProduct[];
}
export class Pagination implements Ipagination {
  pageIndex: number;
  pageSize: number;
  count: number;
  data: IProduct[] = [];
}
