import {ErrorMessage} from "ng-bootstrap-form-validation";

export const CUSTOM_ERRORS: ErrorMessage[] = [
    {
      error: "required",
      format: requiredFormat
    }, {
      error: "email",
      format: emailFormat
    }
  ];
   
  export function requiredFormat(label: string, error: any): string {
    return `${label} không được để trống.`;
  }
   
  export function emailFormat(label: string, error: any): string {
    return `${label} doesn't look like a valid email address.`;
  }

  export function minLengthFormat(label: string, length: number, error: any): string {
    return `${label} tối thiểu ${length} ký tự.`;
  }