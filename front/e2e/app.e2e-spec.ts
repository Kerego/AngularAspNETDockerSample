import { StandupPage } from './app.po';

describe('standup App', () => {
  let page: StandupPage;

  beforeEach(() => {
    page = new StandupPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
