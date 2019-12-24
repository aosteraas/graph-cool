//
//  AppView.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 25/12/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI

struct AppView: View {
    @State var selectedView = 0
    
    init() {
        UITabBar.appearance().barTintColor = UISettings.bagelPink
    }
    var body: some View {
        TabView(selection: $selectedView) {
            ImageColumn()
                .tabItem {
                    Image(systemName: "house")
                    Text("Home")
            }.tag(0)
            AddImageView()
                .tabItem {
                    Image(systemName: "camera")
                    Text("Add")
            }.tag(1)
        }

        .accentColor(.white)
    }
}

struct AppView_Previews: PreviewProvider {
    static var previews: some View {
        AppView()
    }
}
