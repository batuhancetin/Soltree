import { defineStore } from "pinia";

export const useBrandStore = defineStore("brandStore", {
  state: () => {
    return {
      selectedBrand: null as string | undefined | null,
      selectedModel: null,
      selectedDeviceType: null as string | undefined | null,
      toast: false,
    };
  },
});
